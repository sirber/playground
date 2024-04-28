import random

number = random.randint(0,10)

while True:
    guess = int(input("Guess a number between 1 and 10: "))
    if guess == number:
        break

print("bravo!")
