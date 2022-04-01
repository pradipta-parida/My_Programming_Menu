print("Welcome to my computer quiz!")

playing = input("Do you want to play? ")
print(playing)

if playing.lower() != "yes":
    quit()

# lower() --> actually converts any case letters to lower case
# upper() --> actually converts any case letters to upper case

print("Okay! Lets play :) ")
score = 0

answer = input("What does CPU stand for? ")
if answer.lower() == "central processing unit":
    print('Correct!')
    score += 1
# score = score+1
else:
    print('Incorrect!')

answer = input("What does GPU stand for? ").lower()
if answer == "graphics processing unit":
    print('Correct!')
    score += 1
else:
    print('Incorrect!')

answer = input("What does RAM stand for? ")
if answer.lower() == "random access memory":
    print('Correct!')
    score += 1
else:
    print('Incorrect!')

print('you got ' + str(score) + " questions correct !")
# concatenate as int(score) cant be concatenated to string, so we need to convert it into str(score)

print('you got ' + str((score/3)*100) + "%.")
# To print the score in percentage
