import math

def calculate_distance(point1, point2):
  """
  Calculate Euclidian distance.
  """
  return math.sqrt((point1[0] - point2[0]) + (point1[1] - point2[1]))