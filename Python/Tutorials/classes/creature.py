import random


class Creature:
    def __init__(self, power , name):
        self.power=power
        self.name=name

    def fight(self, other):

        if self.power > other.power:
            self.power=self.power-other.power
            other.power=0
            return True
        else:
            self.power=0
            return False

