import re, requests
text = requests.get("https://docs.python.org/3/reference/datamodel.html").text
dunders = sorted({ m for m in re.findall(r'__\w+__', text) })
print(len(dunders), dunders)
