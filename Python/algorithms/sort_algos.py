import random
import copy

arr = [random.randint(1, 999) for _ in range(20)]

######################################################
#    INSERTION SORT
# --------------------
#  Time Complexity:
#  Best: O(n) (already sorted)
#  Average: O(n²)
#  Worst: O(n²)
#  Space Complexity: O(1) (in-place)

def insertion_sort(arr) -> []:
  for i in range(1, len(arr)):
    key = arr[i]
    j = i - 1
    while j >= 0 and arr[j] > key:
      arr[j + 1] = arr[j]
      j -= 1
    arr[j + 1] = key
  return arr

arr_copy = copy.copy(arr)
insertion_sort(arr_copy)
print(f"sorted with insertion sort: {arr_copy}")


######################################################
#    BUBBLE SORT
# --------------------
#  Time Complexity:
#  Best: O(n) (optimized with a swap flag)
#  Average: O(n²)
#  Worst: O(n²)
#  Space Complexity: O(1)

def bubble_sort(arr):
  n = len(arr)
  for i in range(n):
    for j in range(0, n-i-1):
      if arr[j] > arr[j + 1]:
        arr[j], arr[j + 1] = arr[j + 1], arr[j]
  return arr

arr_copy = copy.copy(arr)
bubble_sort(arr_copy)
print(f"sorted with bubble sort: {arr_copy}")

######################################################
#    SELECTION SORT
# --------------------
#  Time Complexity:
#  Best: O(n²)
#  Average: O(n²)
#  Worst: O(n²)
#  Space Complexity: O(1)

def selection_sort(arr):
  for i in range(len(arr)):
    min_idx = i
    for j in range(i+1, len(arr)):
      if arr[j] < arr[min_idx]:
        min_idx = j
    arr[i], arr[min_idx] = arr[min_idx], arr[i]
  return arr

arr_copy = copy.copy(arr)
selection_sort(arr_copy)
print(f"sorted with selection sort: {arr_copy}")

######################################################
#    HEAP SORT
# --------------------
#  Time Complexity:
#  Best: O(n log n)
#  Average: O(n log n)
#  Worst: O(n log n)
#  Space Complexity: O(1)

def heapify(arr, n, i):
  largest = i
  left = 2 * i + 1
  right = 2 * i + 2
  if left < n and arr[left] > arr[largest]:
    largest = left
  if right < n and arr[right] > arr[largest]:
    largest = right
  if largest != i:
    arr[i], arr[largest] = arr[largest], arr[i]
    heapify(arr, n, largest)

def heap_sort(arr):
  n = len(arr)
  for i in range(n // 2 - 1, -1, -1):
    heapify(arr, n, i)
  for i in range(n - 1, 0, -1):
    arr[0], arr[i] = arr[i], arr[0]
    heapify(arr, i, 0)
  return arr

arr_copy = copy.copy(arr)
heap_sort(arr)
print(f"sorted with heap sort: {arr_copy}")
