Master Python Basics — For C# Developers

Goal:
1 - Write clean, idiomatic Python
2 - Understand Python's core syntax & data types
3 - Work with functions, classes, files, and libraries
4 - Know how to use Python for scripting, data processing, or AWS work
5 - Get ready for coding interviews and real-world tasks using Python

✅ Syntax & Data Types Translated from C# 
Key Translations:

C#	----->  Python
int x = 5;  ----->  x = 5
if (x > 5) { ... } 	----->  if x > 5: (no braces!)
for (int i = 0; ...)  ----->  for i in range(n):
Console.WriteLine(...)  ----->  print(...)


✅ Focus: Data Structures – Lists, Dicts, Sets, Tuples

✅ Focus: Functions & Modules

🔹 Hour 4: Classes & OOP in Python
✅ Focus:

Class definitions

__init__ constructor

Instance vs class variables
- In Python, class variables are the equivalent of static members in C#

Inheritance, overriding

@classmethod, @staticmethod

python
Copy
Edit
class Animal:
    def __init__(self, name):
        self.name = name

    def speak(self):
        return f"{self.name} makes a sound"
👉 Translate a small C# class to Python.
Example: Vehicle → Car → ElectricCar.

🔹 Hour 5: File I/O, Exceptions, Context Managers
✅ Focus:

Open/read/write files

Try/except blocks

Use with for safe file/resource handling

python
Copy
Edit
try:
    with open("data.txt", "r") as file:
        contents = file.read()
except FileNotFoundError:
    print("File not found")
🔹 Hour 6: Pythonic Features – Idioms, Lambdas, Comprehensions
✅ Focus:

List/set/dict comprehensions

Lambda functions and map(), filter(), reduce()

enumerate(), zip(), any() and all()

python
Copy
Edit
evens = list(filter(lambda x: x % 2 == 0, range(20)))
squares = [x**2 for x in range(5)]
👉 Convert a loop-based algorithm to Pythonic one-liner.

🔹 Hour 7: Scripting & Libraries (Requests, JSON, OS)
✅ Focus:

requests for APIs

json module for parsing

os, pathlib for working with files/dirs

subprocess for system commands

python
Copy
Edit
import requests
r = requests.get("https://api.github.com")
print(r.json())
👉 Try writing a script that:

Fetches JSON data

Parses and prints values

Saves it to a file

🔹 Hour 8: Real-World Examples & Mini-Project
✅ Options:

AWS Lambda in Python (with boto3)

CLI tool with argparse

Data transformation script (CSV to JSON)

Mini ETL: Read file → transform data → save

Mini Project Idea (20–30 lines):

Build a CLI script that takes a CSV of shipments, filters by destination city, and outputs JSON with summary stats.

⚡ BONUS: Python vs C# Cheat Sheet
Concept	C#	Python
Types	Statically typed	Dynamically typed
Entry Point	static void Main()	if __name__ == "__main__"
List Add	list.Add(x)	list.append(x)
LINQ	list.Where(x => x > 5)	filter(lambda x: x > 5, l)
Properties	get; set;	@property / attributes
Null	null	None
Interfaces	interface	Duck typing (no keyword)
Exceptions	try { } catch { }	try: ... except:

🎯 Tools You Should Know
boto3 (for AWS scripting)

pandas (for data processing)

pytest (for unit tests)

black / flake8 (for formatting/linting)

virtualenv or pipenv (for environments)

✅ You're Ready If You Can:
Write a script from scratch

Use Python to call APIs, process files, or create classes

Explain how Python handles types, memory, and packages

Solve LeetCode problems in Python confidently

## Kaggle Integration

---

pip3 install kaggle