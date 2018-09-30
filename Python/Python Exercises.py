# Write a program that tells the user when they will turn 100 years old.
age = int (input("Enter your age:"))
year = int (2018 - age) + 100

print(f"You will be 100 in {year}")


# Make a rock paper scissors gameself.
ans =  input('Do you want to play a game?')
while ans != "no":
    play1 = input("Enter Player 1 move:")
    play2 = input("Enter Player 2 move:")
    if (play1 == "rock"):
        if play2 == 'scissors':
            print("Player 1 wins")
        elif play2 == 'paper':
            print("Player 2 wins")
        elif play2 == 'rock':
            print("Tie")
    if play1 == 'scissors':
        if play2 == 'rock':
            print("Player 2 wins")
        elif play2 == 'paper':
            print("Player 1 wins")
        elif play2 == 'scissors':
            print("Tie")
    if play1 == 'paper':
        if play2 == 'scissors':
            print("Player 2 wins")
        elif play2 == 'rock':
            print("Player 1 wins")
        elif play2 == 'paper':
            print("Tie")
    ans =  input("Do you want to play a game?")
