import random
import time


score = 0
e = 1
print("Welcome to guess the number game")
time.sleep(2)
print("Your goal is obviously to guess the number")
time.sleep(2)
print("You will have 4 attempts to do so")
time.sleep(2)
print("But before we start, please, pick the difficulty")
time.sleep(2)
dif = int(input("Type 1 to chose EASY, 2 to chose NORMAL or 3 to chose HARD "))
print("Enjoy!!")
if  dif == 1:
    num = 10
    while(e == 1):
        countdown = 0
        number = int(random.randint(1, num))
        s = 1
        while(countdown != 4):
            answer = int(input("Pick a number between 1 and 10 "))
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
elif dif == 2:
    num = 20
    while(e == 1):
        countdown = 0
        number = int(random.randint(1, num))
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
else:
    num = 30
    while(e == 1):
        countdown = 0
        number = int(random.randint(1, num))
        s = 1
        while(countdown != 4):
            answer = int(input("Pick a number between 1 and 30 "))
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
   
