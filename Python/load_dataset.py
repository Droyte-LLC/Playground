# Import necessary libraries
import pandas as pd
import os

# Print the current working directory
print("Current Working Directory:", os.getcwd())

# Load the dataset from a CSV file
df = pd.read_csv("./Python/StockMarketDataset.csv")

# Display the first 5 rows of the DataFrame
print("First 5 rows of the dataset:")
print(df.head())