import random
import time


score = 0
e = 1
print("Welcome to guess the number game")
time.sleep(2)
print("Your goal is obviously to guess the number")
time.sleep(2)
print("You will have 4 attpempts to do so")
time.sleep(2)
print("Enjoy!!")

while(e == 1):
    countdown = 0
    number = int(random.randint(1, 20))
    s = 1
    while(countdown != 4):
        answer = int(input("Pick a number between 1 and 20 "))
        if answer ==  number:
            print()
            print("Well done, 1 point for you")
            score = score + 1
            print("Your score is :", score)
            countdown = 4
            s = 0
        elif answer != number:
            if number >= answer:
                print("Your answer is too small")
            else:
                print("Your answer is too big")
    if  s == 1:
        print()
        print("No points for you")
        print("Your score is :", score)
   
