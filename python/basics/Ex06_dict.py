person = {"name": "roger", "gender": "male", "age": 23, "adress": "123", "phone": "124"}
key = input("Quel information? ")
print(person.get(key, "information invalide"))
