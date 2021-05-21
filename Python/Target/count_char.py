def main():
    count_char('foobaroo')

def count_char(ip):
    charDictionary = {}
    charCount={}
    for char in ip:
        if char in charDictionary:
            charDictionary[char] = charDictionary[char]+1
        else:
            charDictionary[char] = 1

    print(charDictionary)

if __name__ == '__main__':
    main()
