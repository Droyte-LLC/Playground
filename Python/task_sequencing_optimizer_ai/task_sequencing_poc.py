import pandas as pd #DataFrame and Series for structured data manipulation
import numpy as np #High performance numerical computing, arrays and vectorized ops
from sklearn.model_selection import train_test_split #Machine learning preprocessing, modeling and validation
from sklearn.ensemble import GradientBoostingRegressor

# Generating synthetic task data
np.random.seed(48) #Reproducible random sequence
num_tasks = 1100 #Number of tasks

# Create flattened table of task features
data = pd.DataFrame({
    "task_id": range(1, num_tasks + 1),
    "processing_time": np.random.uniform(1, 60, num_tasks),
    "deadline_minutes": np.random.uniform(5, 180, num_tasks),
    "urgency": np.random.randint(1, 6, num_tasks),  # 1 (low) to 5 (high)
    "resource_load": np.random.uniform(0.1, 1.0, num_tasks),
    "distance": np.random.uniform(1, 500, num_tasks)
})