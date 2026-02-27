#!/usr/bin/env python3

import os # Interact with OS environment
import sys # Runtime and cmd args
import tempfile # Temporary files and directories
import shutil # High level file operations
import subprocess # Execute shell commands or external programs
import json # # Json utility
from pathlib import Path # Object oriented file paths
import time # Time utility

def run(cmd, cwd=None, capture=True):
  print(f"▶ {' '.join(cmd)}")
  if capture:
    result = subprocess.run(cmd, cwd=cwd, capture_output=True, text=True) # check=True automatically raises exception if check=True tells Python to automatically raise an exception if the process exits with a non-zero status.
    if result.returncode != 0:
      print("❌ Command failed!")
      print("STDOUT:", result.stdout)
      print("STDERR:", result.stderr)
      result.check_returncode()
      return result.stdout.strip()
  else:
    subprocess.run(cmd, cwd=cwd, check=True)

def ensure_env():
  if not os.getenv("GITHUB_TOKEN"):
    print("❌ GITHUB_TOKEN not set.")
    sys.exit(1)


def create_repo(org, repo_name, access):
  ensure_env()

  workdir = Path(tempfile.mkdtemp())
  repo_path = workdir / repo_name
  repo_path.mkdir()

  try:
    # Init git
    run(["git", "init", "-b", "main"], cwd=repo_path)

    # Create README
    readme = repo_path / "README.md"
    readme.write_text(f"# {repo_name}\n\nBootstrapped by Droyte Vibe Coder Agent.\n")

    create_from_json(
      base_path=repo_path,
      json_file=Path(__file__).resolve().parent / "repo_folders.json"
    )

    # Initial commit
    run(["git", "add", "."], cwd=repo_path)
    run(["git", "commit", "-m", "Initial commit"], cwd=repo_path)

    # Create GitHub repo
    run([
      "gh",
      "repo",
      "create",
      f"{org}/{repo_name}",
      access,
      "--source=.",
      "--remote=origin",
      "--push"
    ], cwd=repo_path)

    print("🚀 Repo successfully created and pushed.")

    # Get HTTPS repo URL
    output_url = None
    for _ in range(3):
        result = subprocess.run(
            ["gh", "repo", "view", f"{org}/{repo_name}", "--json", "url"],
            capture_output=True,  # capture stdout and stderr
            text=True             # decode bytes to str
        )
        if result.stdout:  # check if stdout has content
            output_url = result.stdout
            break

        print("⚠️ Repo not ready yet, retrying...")
        time.sleep(1)

    if not output_url:
      raise RuntimeError("GitHub CLI did not return any JSON output.")

    data = json.loads(output_url)
    repo_url = data.get("url")
    print(f"🚀 Repo URL: {repo_url}")

  finally:
    shutil.rmtree(workdir)
    print("🧹 Cleaned up temp directory.")


EXCLUDED_PACKAGE_DIRS = {
  ".github",
  "terraform",
  "docker",
  "scripts",
}

def create_from_json(base_path: Path, json_file: Path):
  """
  Builds folder/file structure from JSON.
  Automatically inserts __init__.py for Python package directories.
  """

  with open(json_file, "r") as f:
    structure = json.load(f)

  def contains_python(node):
    """Recursively check if node contains Python files."""
    if node.get("type") == "file" and node.get("value", "").endswith(".py"):
      return True

    for child in node.get("children", []):
      if contains_python(child):
        return True

    return False

  def create_node(node, current_path: Path):
    node_type = node.get("type")
    value = node.get("value", "")

    if node_type == "folder":
      folder_path = current_path / value if value else current_path
      folder_path.mkdir(parents=True, exist_ok=True)

      children = node.get("children", [])

      # Recursively create children first
      for child in children:
        create_node(child, folder_path)

      # Add __init__.py if folder should be a Python package
      if (
        value not in EXCLUDED_PACKAGE_DIRS
        and contains_python(node)
        and value != ""
      ):
        init_file = folder_path / "__init__.py"
        init_file.touch(exist_ok=True)

    elif node_type == "file":
      file_path = current_path / value
      file_path.parent.mkdir(parents=True, exist_ok=True)

      if not file_path.exists():
        file_path.touch()

  # Root children define repo structure
  for child in structure.get("children", []):
    create_node(child, base_path)

  print("✅ Project scaffold created with automatic __init__.py placement.")

if __name__ == "__main__":
  if len(sys.argv) != 4:
    print("Usage: python create_repo.py <NewRepo> <access>")
    sys.exit(1)

  create_repo(sys.argv[1], sys.argv[2], sys.argv[3])