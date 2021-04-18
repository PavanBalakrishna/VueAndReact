from PIL import Image
import numpy as np
import random

k1 = random.randint(6,900)  # Key 1  # Key 3


def Encrypt():  # Takes the input from the user and takes the n value to generate various keys from the inputed key
    M_key=int(abs(hash(input("Enter a key : "))))
    n=int(input("Enter a number : "))
    key_list=[int(x) for x in str(M_key)]
    key_create=[]
    print(key_list)
    #for i in range(10):
    for x in str(M_key):
        key_list.append(int(x))
    print(key_list)
    for i in range(len(key_list)):
        if i % (n+2) ==0 :
            key_create.append(key_list[i])
        else:
            if (i==(len(key_list)-1)):
                key_create.append(key_list[i])
            else:
                key_create.append(key_list[i+1])
    print(key_create)
    key_arr=np.array(key_create)
    f = open("Test2.jpg","rb")  # Creats a file in Read Binary mode
    image = Image.open("Test2.jpg")  # Opens the image Test.png
    f.close()
    print(image)
    image = np.array(image)  # Converts the Image into a numpy array
    print(image)
    print(image.shape)  # Prints out the shape of the numpy array i.e; Rows and Columns
    global row
    global column
    global w
    row = image.shape[0]  # Points to the row
    column = image.shape[1]  # Points to the column
    w=image.shape[2]
    print(row, column)
    #Time for manipulation
    RGB_enc=image^k1
    print("-----------------------")
    print(RGB_enc)
    print("-----------------------")
    #RGB_enc=np.transpose(RGB_enc)
    key_arr=np.repeat(key_arr,(row*column*3)/key_arr.size)
    print(key_arr.size)
    print(key_arr.shape)
    if(key_arr.size<(row*column*w)):
        for i in range((row*column*w)-key_arr.size):
            key_arr=np.append(key_arr,[0])
    print(key_arr.size)
    print(key_arr.shape)
    key_arr= np.reshape(key_arr,(row, column,w))
    print(key_arr.shape)
    RGB_enc=RGB_enc*key_arr
    print(RGB_enc)
    RGB_enc=np.transpose(RGB_enc)
    print(RGB_enc)
    print(RGB_enc.shape)
    RGB_enc[:, [column-1, 0]] = RGB_enc[:, [0, column-1]]
    print(RGB_enc)
    RGB_encrypt = RGB_enc.astype(np.uint8)# converts the entire matrix to uint8
    print(RGB_encrypt)
    RGB_encrypt= np.reshape(RGB_encrypt,(row, column,w))
    img = Image.fromarray(RGB_encrypt)  # Saves the image
    img.save("ENC.jpeg")
    print("ENCRYPTED!!!!!--------------------------------------------------------")
    RGB_dec=RGB_enc
    RGB_dec[:, [0, column-1]] = RGB_dec[:, [column-1, 0]]
    RGB_dec=np.transpose(RGB_dec)
    print(RGB_dec)
    RGB_dec=RGB_dec/key_arr
    RGB_dec=np.nan_to_num(RGB_dec)
    print(RGB_dec)
    RGB_dec=RGB_dec.astype(int)
    RGB_dec=RGB_dec^k1
    #RGB_dec = np.bitwise_xor(RGB_dec, k1)
    #RGB_dec=RGB_enc^k1
    RGB_decrypt = RGB_dec.astype(np.uint8)
    img = Image.fromarray(RGB_decrypt)  # Saves the image
    img.save("DEC.jpeg")
Encrypt()
