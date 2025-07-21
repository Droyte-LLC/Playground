import pandas as pd

import os
print("Current Working Directory:", os.getcwd())

df = pd.read_csv("./Python/StockMarketDataset.csv")
print(df.head())