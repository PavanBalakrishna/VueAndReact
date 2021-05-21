def main():
   print(min_dist([10,7,4,21,99],[21,7]))

def min_dist(mainArray ,arrayItems):
    distance = len(mainArray) + 1
    for i in range(len(mainArray)):
        for j in range(i + 1, len(mainArray)):
            if (arrayItems[0] == mainArray[i] and arrayItems[1] == mainArray[j] or
                arrayItems[1] == mainArray[i] and arrayItems[0] == mainArray[j]) and distance > abs(i-j):
                distance = abs(i-j)
        return distance

if __name__ == '__main__':
    main()