import requests
import random
import html

quizz_url = "https://opentdb.com/api.php?amount=1&category=12&difficulty=easy"
score = 0

while True:
    r = requests.get(quizz_url)
    try:
        questions = r.json()
    except:
        print("Could not query api")
        break
        
    question = questions["results"][0]
    answers = question["incorrect_answers"]
    answers.append(question["correct_answer"])
    random.shuffle(answers)

    print(html.unescape(question["question"]))
    answer_number = 1
    for answer in answers:
        print(str(answer_number) + "-", html.unescape(answer))
        answer_number += 1

    user_answer = input("Answer? ")
    user_answer = answers[int(user_answer) - 1]

    if user_answer == question["correct_answer"]:
        score += 1
        print("Correct!")
    else:
        print("Incorrect! it was:", question["correct_answer"])

    play_again = input("Play again? answer 'quit' to stop: ")
    if play_again == "quit":
        break

print("Score:", score)
