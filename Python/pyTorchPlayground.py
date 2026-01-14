import torch

print(f'Welcome to PyTorch Playground!')
# initializing a tensor
my_tensor = torch.tensor([ [5, 3, 7], [2, 1, 8] ], dtype=torch.float, requires_grad=True)
print(f'my_tensor = {my_tensor}')

print(f'Example using shape:')
# 5 rows, 4 columns
shape = (5, 4) 
# 4 rows, 5 columns
shape2 = (4, 5) 

# initializing a tensor with zeros values
my_zeros_tensor = torch.zeros(shape)

# initializing a tensor with ones values
my_ones_tensor = torch.ones(shape)

# initializing tensors with random values
my_random_tensor = torch.randn(shape, requires_grad=True)
my_random2_tensor = torch.randn(shape, requires_grad=True)

# this operation will create a gradients function
some_tensor = my_random_tensor * my_random2_tensor

print(f'my_zeros_tensor: {my_zeros_tensor}')
print(f'my_ones_tensor: {my_ones_tensor}')
print(f'my_random_tensor: {my_random_tensor}')

# creating a tensor from another tensor
print(f'new tensor from another tensor')
new_tensor = torch.randn_like(my_ones_tensor, dtype=torch.float)
print(f'new_tensor = torch.randn_like(my_ones_tensor, dtype=torch.float) results in new_tensor being set to: {new_tensor}')

# important tensor attributes
print(f'type, device and shape are critical tensor attributes')
print(f'my_ones_tensor.shape = {my_ones_tensor.shape}')
print(f'my_ones_tensor.dtype = {my_ones_tensor.dtype}')
print(f'my_ones_tensor.device = {my_ones_tensor.device}')
print(f'new_tensor.dtype = {new_tensor.dtype}')

print(f'computation graph for every tensor created by an operation (aka breadcrumbs')

print(f'gradients function for some_tensor = my_random_tensor * my_random2_tensor')
print(f'some_tensor.grad_fn: {some_tensor.grad_fn}')

print(f'* is used for elementwise multiplication and requires same shape')
print(f'@ or torch.matmul is used neural network computations and requires Rule: m1 columns = m2 rows')

# reduction functions
print(f'Reduction (collapse) functions')
print(f'sum()')
print(f'my_random2_tensor = {my_random2_tensor}')
print(f'my_random2_tensor.sum() = {my_random2_tensor.sum()}')
print(f'my_random2_tensor.sum(dim=0) = {my_random2_tensor.sum(dim=0)}')
print(f'my_random2_tensor.sum(dim=1) = {my_random2_tensor.sum(dim=1)}')

print(f'mean()')
print(f'my_random2_tensor = {my_random2_tensor}')
print(f'my_random2_tensor.mean() = {my_random2_tensor.mean()}')
print(f'my_random2_tensor.mean(dim=0) = {my_random2_tensor.mean(dim=0)}')
print(f'my_random2_tensor.mean(dim=1) = {my_random2_tensor.mean(dim=1)}')

print(f'max() - Note: returns values and optional indices if dim param is specified')
print(f'my_random2_tensor = {my_random2_tensor}')
print(f'my_random2_tensor.max() = {my_random2_tensor.max()}')
print(f'my_random2_tensor.max(dim=0) = {my_random2_tensor.max(dim=0)}')
print(f'my_random2_tensor.max(dim=1) = {my_random2_tensor.max(dim=1)}')

# torch.argmax() only returns indices
print(f'torch.argmax() - Note: returns indices only')
print(f'torch.argmax(some_tensor, dim=1) = {torch.argmax(my_random2_tensor, dim=1)}')

# example for creating a tensor with 12 elements, reshaped into 3 rows and 4 columns
print(f'torch.arange')
print(f'torch.arange(12).reshape(3,4) = {torch.arange(12).reshape(3,4)}')

# syntax to return a certain column
print(f'get the 3rd column')
print(f'my_random2_tensor 3rd column: {my_random2_tensor[:, 2]}')

# TODO
#print(f'customized and optimal get')
#print(f'torch.tensor([ [], [], [], [] ]) means give me the 4th element from the 1st row, 3rd from 2nd row')
#torch.gather(some_tensor, dim=1, index=indices_to_select)
#where indices_to_select could be torch.tensor( [ [1], [3], [0] )


