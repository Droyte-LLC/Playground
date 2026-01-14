✔ You must create a new conda environment with Python 3.10 (or 3.11) for PyTorch.

Run this:
conda create -n torch python=3.10

Activate it:
conda activate torch

Verify Python version:
python --version

It should now show Python 3.10.x.
Now install PyTorch inside that environment

For CPU:
pip install torch torchvision torchaudio --index-url https://download.pytorch.org/whl/cpu

pip install torch==2.2.2 numpy==1.26.4 transformers coremltools



🧠 Why you see multiple versions
Because:
Conda "activates" its own Python by modifying your PATH
Homebrew adds a Python to /usr/local/bin
macOS ships its own Python in /usr/bin

which -a python OR which -a python3

---------------------------------------
Testing Python environment with Conda
---------------------------------------
which python
which python3
python --version
python3 --version


-----------------------------
Verify PyTorch is installed
-----------------------------
conda activate torch
python -c "import torch; print(torch.__version__)"


------------------------------------
Downgrade Numpy to support PyTorch
Verify Numpy is installed
------------------------------------
conda activate torch
pip install "numpy<2"
python -c "import numpy; print(numpy.__version__)"



