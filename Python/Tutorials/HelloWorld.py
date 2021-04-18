from Tutorials.classes.creature import Creature
from Tutorials.classes.room import Room


def main():
    printfunc()

def printfunc():
    print("Welcome to the Game")

    play_game()

def build_Rooms():
    godzilla = Creature(19,'Godzilla')
    kingkong = Creature(27, 'kingkong')
    Mogambo = Creature(30, 'Mogambo')
    MogambosLair = Room('Mogambos Lair', Mogambo)
    island = Room('Treasure island', kingkong, None, MogambosLair)
    cave = Room('Black cave',godzilla,None,None,island)
    entryroom = Room('Main hall',None,None,cave)
    return entryroom



def play_game():
    roomscovered=1
    you=Creature(200,'Pavan')
    room=build_Rooms()

    print('Welcome {} ! Are you ready for an adventure of a lifetime !!!! Proceed with caution'.format(you.name))
    print(f'You have entered the {room.name} !!!')
    while you.power > 0:
        if room.creature and room.creature.power > 0:
            print('Oh my goodess , you have encountered {} !!! Fight {} NOW !'.format(room.creature.name,room.creature.name))
            if you.fight(room.creature):
                print('YOU WON ! Move to another room but you only have {} power left'.format(you.power))

            else:
                print('You have been DEFEATED !!!')
        action = input('Move Left(L) or right (R) : ').lower().strip()

        if action == 'l' and room.left:
            roomscovered = roomscovered + 1
            print('You have entered "{}"'.format(room.left.name))
            room = room.left

        elif action == 'r' and room.right:
            roomscovered = roomscovered + 1
            print('You have entered {}'.format(room.right.name))
            room = room.right
        elif not room.left and not room.right:
            print('GAME OVER ! YOU WON ! Total rooms {}'.format(roomscovered))
            break
        else:
            print('Nothing here try another direction')


    print('GAME OVER ! Total rooms {}'.format(roomscovered))

if __name__ == '__main__':
    main()
