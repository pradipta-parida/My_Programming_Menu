"""
Variables - are containers for storing values.
            without repeating/printing the values again and again, we can set a variable and use it.

Python defined variables are dynamic in nature, can be string or int etc.

Naming Convention : is a convention (generally agreed scheme) for naming things.
                    - use lowercase with words separated by Underscores
                    - use descriptive variable name, to let know other coders about
                      the value through variable name

"""

'''
print(f"20 days are {20 * 24 * 60 * 60} seconds")
print(f"35 days are {35 * 24 * 60 * 60} seconds")
print(f"50 days are {50 * 24 * 60 * 60} seconds")
print(f"110 days are {110 * 24 * 60 * 60} seconds")

'''

calculation_to_seconds = 24 * 60 * 60
name_of_unit = "seconds"

# to tell formatter(f) , {name_of_unit} is not a string,is a non-string value

print(f"20 days are {20 * calculation_to_seconds} {name_of_unit}")
print(f"35 days are {35 * calculation_to_seconds} {name_of_unit}")
print(f"50 days are {50 * calculation_to_seconds} {name_of_unit}")
print(f"110 days are {110 * calculation_to_seconds} seconds")
