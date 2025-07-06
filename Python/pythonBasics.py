# Equivalent to Console.WriteLine in C#
print('hello world')

# Variables can be assigned without type declaration
x = 10

# Indent replaces curly braces
if x > 5:
	print('x is greater than 5') 

# For loop
for i in range(5):
	print(i)

# type hints for static typing
def greet(name: str) -> str:
		return f"Hello, {name}!"

# another type hint 
name: str = "Alice"
print(greet(name))

# mypy is a static type checker for Python,
# it checks the type hints you provide in your code.
# it helps you catch type errors before running your code.
# needs to be installed: # pip3 install mypy
# To run mypy, use the command: mypy pythonBasics.py
# if you run into issues running mypy, 
# echo 'export PATH="$HOME/Library/Python/3.13/bin:$PATH"' >> ~/.bashrc
# and then run 'source ~/.bashrc' to update your PATH

# example of a list, dictionary, set, and tuple
my_list = [ 1, 2, 3 ]
my_dict = { 'someKey': 'someValue', 'otherKey': 42 }
my_set = { 1, 2, 3 }
my_tuple = ( 10, 'yes' )

print(my_list)
print(my_dict)
print(my_set)
print(my_tuple)

# loop through a list, use f-strings for formatting, interpolation
for item in my_list:
	print(f"list item: {item}")

# loop through a dictionary
for key, value in my_dict.items():
	print(f"key: {key}, value: {value}")

# add an item to a list
my_list.append(4)
print(my_list)

# add an item to a dictionary
my_dict['newKey'] = 'newValue'
print(my_dict)

# add an item to a set
my_set.add(4)
print(my_set)

# add an item to a tuple (tuples are immutable, so this creates a new tuple)
my_tuple = my_tuple + (5,)
print(my_tuple)

# remove an item from a list
my_list.remove(2)
print(my_list)		

# remove an item from a dictionary
del my_dict['someKey']
print(my_dict)

# remove an item from a set
my_set.remove(1)
print(my_set)

# remove a specific item from a tuple (tuples are immutable, so this creates a new tuple)
my_tuple = tuple(x for x in my_tuple if x != 10)
print(my_tuple)

# sort a list
my_list.sort()
print(my_list)

# sort a dictionary by keys
sorted_dict = dict(sorted(my_dict.items()))
print(f"sorted dictionary: {sorted_dict}")

# sort a set (sets are unordered, so this creates a sorted list)
sorted_set = sorted(my_set)
print(sorted_set)

# sort a tuple (tuples are immutable, so this creates a new sorted tuple)
# if you have multiple data types, filter by desired type first to avoid errors
my_tuple = (10, 5, 3, 1, 'yes', 'no')
my_tuple = tuple(x for x in my_tuple if isinstance(x, int)) # filter
sorted_tuple = tuple(sorted(my_tuple))
print(sorted_tuple)

# slice a list
sliced_list = my_list[1:3]  # gets items from index 1 to 2
print(sliced_list)

# slice a dictionary (dictionaries don't support slicing, but you can create a new dict)
sliced_dict = {k: my_dict[k] for k in list(my_dict.keys())[1:3]}
print(sliced_dict)

# slice a set (sets don't support slicing, but you can convert to a list)
sliced_set = list(my_set)[1:3]  # gets items from index 1 to 2
print(sliced_set)

# comprehensions are:  loop + conditional + return all in one line
# comprehensions can be compaared to LINQ in C#
# comprehensions for lists, dictionaries, and sets
list_comp = [x * 2 for x in my_list if x > 2]
print(list_comp)

dict_comp = {k: v * 2 for k, v in my_dict.items() if isinstance(v, int)}
print(dict_comp)

set_comp = {x * 2 for x in my_set if x > 2}
print(set_comp)

squares = [x * x for x in range(10) if x % 2 == 0]
print(squares)

print("FUNCTIONS & MODULES")
print("\n-- Defining functions --")
# example using def to define a function, with default parameter
# """ replaces XML comments in C# """

"""Greets the user with a name."""
def greet(name="World"):	
	return f"Hello, {name}"

print(greet())  # No argument, uses default
print(greet("Playground"))  # With argument

print("\n-- Importing modules --")
from math import sqrt

print(f"The square root of 16 is {sqrt(16)}")

# **args and **kwargs are used to pass a variable number of arguments to a function
def variable_args(*args, **kwargs):
	print("Positional arguments:", args)
	print("Keyword arguments:", kwargs)

variable_args(1, 2, 3, name="Alice", age=30)

# returning multiple values via tuples
def return_multiple():
	return 1, "two", 3.0

a, b, c = return_multiple()
print(f"Returned values: {a}, {b}, {c}")

# or
result = return_multiple()
print(f"Returned values: {result[0]}, {result[1]}, {result[2]}")

# example reusable utility function
def is_even(num: int) -> bool:
	"""Check if a number is even."""
	return num % 2 == 0

print(f"Is 4 even? {is_even(4)}")
print(f"Is 5 even? {is_even(5)}")

# modules are equivalent to namespaces in C#
# you can create a module by creating a .py file with functions and classes
# and then importing it in another file

# A small module with a main() method
def main():
	print("This is a simple module with a main function.")

if __name__ == "__main__":
	main()  # This will run only if the script is executed directly, not when imported

# Call functions from another file
# To call functions from another file, you can import the module
# For example, if you have a file named `my_module.py` with a function `my_function()`,
# you can import it like this:
from myPythonModule import main2
main2()  # This will call the function from the imported module
# my_function()  # This will call the function from the imported module