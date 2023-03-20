import random
import time
e = 0
Lenght = int(input("Enter number of characters "))
Words = int(input("Enter number of words "))
print("Number of characters   ........ ", Lenght)
print("  Number of words      ........ ", Words)
print()

print("Generating", end="")
for i in range(5):
    print(".", end="")
    time.sleep(0.4)
print()

for i in range(Words):
    for i in range(Lenght):
        letter = chr(random.randint(65, 90)) 
        print(letter, end="")
        time.sleep(0.1)
    print(end=" ")

        
