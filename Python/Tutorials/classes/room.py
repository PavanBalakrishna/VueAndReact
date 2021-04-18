class Room:
    def __init__(self,name='My R    oom',creature=None,
                 contents=None,left=None,right=None,forward=None):
        self.forward = forward
        self.right = right
        self.left = left
        self.contents = contents
        self.creature = creature
        self.name = name