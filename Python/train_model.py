import pandas as pd
from sklearn.model_selection import train_test_split
from sklearn.ensemble import RandomForestClassifier
from sklearn.multioutput import MultiOutputClassifier
import joblib
import os

# Load already sanitized and labeled dataset
df = pd.read_csv("./Python/StockMarketDataset_Sanitized_Labeled.csv")

# Define label columns: all one-hot encoded risk columns
label_cols = [col for col in df.columns if '_Risk_' in col]

# Define features: drop date and risk labels
X = df.drop(columns=['Date'] + [col for col in df.columns if col.endswith('_Risk')])
y = df[label_cols]

# Split dataset for training/testing
X_train, X_test, y_train, y_test = train_test_split(X, y, test_size=0.2, random_state=42)

# Train MultiOutput RandomForestClassifier
model = MultiOutputClassifier(RandomForestClassifier(n_estimators=100, random_state=42))
model.fit(X_train, y_train)

# Save model to disk
os.makedirs("outputs", exist_ok=True)
joblib.dump(model, "outputs/risk_volatility_model.pkl")

print("✅ Model training complete. Saved to outputs/risk_volatility_model.pkl")
