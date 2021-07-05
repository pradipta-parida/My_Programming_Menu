'''

Set does not allow duplicates.
can be used to store any no. of vales/objects,dynamically.

'''

s={10,20,30,"XYZ",10,20,10}

s.update([88,99])

print(type(s))

#print(s*3)
s.remove(30)
print(s)

f=frozenset(s)
f.remove(20)