print("simple array")
items = [1,2,3,4]
for item in items:
    print(item)

print("string")
item = "string"
for x in item:
    print(x)

print("dictionary")
items = {"name": "bob"}
for key in items:
    print(key, ":", items[key])
for (key, value) in items.items():
    print(key, ":", value)

print("range")
for x in range(0,10):
    print(x)
