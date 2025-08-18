def fizzBuzz(n: int):
  if n > 0:
    for i in range(1, n+1):
      if i % 5 == 0 and i % 3 == 0:
        print(f"FizzBuzz")
      elif i % 3 == 0:
        print(f"Fizz")
      elif i % 5 == 0:
        print(f"Buzz")
      else:
        print(i)

fizzBuzz(15)