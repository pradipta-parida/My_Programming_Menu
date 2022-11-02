#Indentation refers to the spaces provided before the code.
#Python uses indentation for a block of codes.

x=int(input("Enter minimum number"))
y=int(input("Enter maximum number"))
i=x
if i%2==0 : i=x+1
while i<=y:
    print(i)
    i+=2