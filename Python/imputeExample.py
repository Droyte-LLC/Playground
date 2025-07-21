import pandas as pd
import numpy as np

# Sample data
data = {'A': [1, 2, np.nan, 4, 5, np.nan, 7]}
df = pd.DataFrame(data)

# Before imputation
print("Before imputation:")
print(df)

# Impute missing values with median
df['A'].fillna(df['A'].median(), inplace=True)

# After imputation
print("\nAfter imputation:")
print(df)
