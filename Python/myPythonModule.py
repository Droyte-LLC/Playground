# create a module with main() method
# 	main()
## Example of a module with a main() method
def main2():
  print("This is a simple module with a main2 function.")
  
if __name__ == "__main__":
	main2()
     
# Example of a class in Python
class Risk:
  description = "This is a class to represent a risk score."  # class variable
  def __init__(self, name, score): # constructor
    """Initialize the Risk instance with a name and score."""
    self.name = name      # instance variable
    self.score = score        # instance variable

  def show(self):
    print(f"Showing risk score, risk: {self.name}, score: {self.score}")

# Example of inheritance and method overriding
# Animal class is a base class
class Animal:
  def speak(self):
    print("The animal makes a sound")

class Dog(Animal):
  def bark(self):  # New method specific to Dog
    print("It Barks")
  def speak(self):  # Overrides Animal's speak
    super().speak()  # Call the base class method
    print("The dog make a sound")


     

