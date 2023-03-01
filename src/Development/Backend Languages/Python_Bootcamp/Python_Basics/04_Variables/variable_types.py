# Basic Data Types in Python : Numbers, Strings, Booleans, Sequences(List, Tuple), Dictionaries

myint = 5
myfloat = 13.2
mystr = "This is a string" # Global Variable (declared outside of a function)
mybool = True
mylist = [0, 1, "two", 3.2, False]
mytuple = (0, 1, 2)
mydict = {"one": 1, "two": 2}
""" 
string "one" maps to the value one here and the string "two" maps to the value two.
Now, In Dictionary the keys("one" , "two") have to be unique values(1,2) but the values don't have to be unique
"""

print(myint)
print(myfloat)
print(mystr)
print(mybool)
print(mylist)
print(mytuple)
print(mydict)

# re-declaring a variable works
myint = "abc"
print(myint)

# to access a member of a sequence type, use []. First, element in an array will be indexed as 0,1,2 and so on..
print(mylist[2])
print(mytuple[1])
'''
list and tuple are zero-based index.
so if you want to get the 3rd item from list then it will be [2]
and, if you want 2nd item from tuple then the index will be [1]
'''

# use slices to get parts of a sequence
print(mylist[1:5])
print(mylist[1:5:2])
''' 
slice notation to access a subset of a sequence.
so, if i want to get the first index here all the way to the end of my list(two indices whereyou want to get subset from)
and, if i want to get the second through the fifth items in my list, while skipping every second one(step value). 1 here start index
5 here end index and 2 is step value

'''

# you can use slices to reverse a sequence
print(mylist[::-1])
"""
So, here not specifying the start value, not specifying end value\.so,its going to be default start and default end
,which is the entire sequence and the step value is going to be -1
"""

# dictionaries are accessed via keys

"""
Dictionaries don't work with indexes. In this case, you give them the key of the item that you want and they return
the value associated with that key
"""
# So, if i want to retrieve the value associated with this key of "one" right here, then
print(mydict["one"])

# ERROR : Variables of different types can't be combined
"""
When we try to combine/concatenate two different data types, it throws an error.So, you have to have all the arguments
be the same type when concatenating a string like this
"""
# print("String type" + 123)
print("String Type" + " " +str(123))

# Global Vs Local Variables in Functions
"""
In Python, Indentation by some spaces before line of codes indicates they belong to some functions.

Global Variables - variables that are defined outside of a function and can be used within and outside functions
"""
# def someFunction():
#     mystr = "Good" # Local Variable (declared inside a function)
#     print(mystr)


def someFunction():
    global mystr
    mystr = "Good"  # Local Variable (declared inside a function)
    print(mystr)

someFunction() # calling the function
print(mystr)

"""
Now,If I actually want to affect the value of the Global variable. I have to tell the function that there is a global
variable named mystr, and thats the value it should make changes to.So, we are going to write the word "global"
and then i am going to use the variable name of mystr. so, the global statement with the name of the variable 
indicates to python that this variable exists in the global namespace and is declared somewhere else.
"""

"""
del keyword used for deleting the defination of a variable that was previously declared.So, you
can undefine in real times using the del statement
"""
del mystr
print(mystr)
