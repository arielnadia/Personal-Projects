# Help Ariel and Ryan decide where to eat!

import random

def main():
    print('Where Should We Eat?')
    pick_a_place()
    print('Dine-In or Carry-Out?')
    in_or_out()

def pick_a_place():
    Restaurants = ('Restaurant1', 'Restaurant2', 'Restaurant3')
    Number = random.randint(0,(len(Restaurants)-1))
    print(Restaurants[Number])

def in_or_out():
    Number = random.randint(0,1)
    if Number == 0:
        print('Dine-In')
    else:
        print('Carry-Out')

main()
