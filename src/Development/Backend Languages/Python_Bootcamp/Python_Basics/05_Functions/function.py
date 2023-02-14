"""
To avoid duplicating a whole line or whole piece of code basically which has multiple different stuff
in it .

Functions - are basically smaller blocks of code, used to avoid repeating. It gives us a way of organizing 
our programs, so that they are more understandable and modular 

"""

# TODO: define a basic function

def func1(): # This function doesn't take any arguments inisde (). ":" indicates the starting of the scope/body/function
    print("I am a function") #Here, the print statement is indented by four spaces. And Its, upto you how many spaces you want to indent your code.
                             #It can be 4,3,2,8

func1() #The function is being called directly, which executes the contents of the function, causing the print statement to print the string
print(func1()) #The function is being called inside the print statement
print(func1)