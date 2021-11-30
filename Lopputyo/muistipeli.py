
import tkinter as tk
from tkinter import *
from tkinter import font
Laajenna
peli2.py
6 kt
tossa vaan pelkästään kuva, tosta funktiosta
Kuva
﻿
#Luodaan muistipeli, jossa käyttäjän on löydettävä oikeat parit

import random
import tkinter as tk
from tkinter import *
from tkinter import font
from tkinter import messagebox

root = Tk()
root.geometry("600x600")

nameLabel = Label(root, text="MUISTIPELI", font=("Verdana", 24))
nameLabel.pack()

#Luodaan lista muistipelissä olevista pareista
pairs = [1,1,2,2,3,3,4,4,5,5,6,6,7,7,8,8]

#Arvotaan parit omiin ruutuihin
random.shuffle(pairs)

#Luodaan buttoneille frame, johon ne laitetaan
game_frame = Frame(root)
game_frame.pack(pady=10)

#Määritetään muuttujat buttoneiden klikkausta varten
count = 0
ans_list = []
ans_dict = {}
pairs_found = 0



#Määritetään buttoneille funktio, kun niitä painetaan
def button_click(button, num):
    global count, ans_list, ans_dict, pairs_found
    
    if button["text"] == '' and count < 2:
        
        button["text"] = pairs[num]
        #Lisätään listaan button, josta katsottiin numero
        ans_list.append(num)
        #Lisätään painettu button ja siinä ollut numero dictionaryyn
        ans_dict[button] = pairs[num]
        #Lisätään laskuriin klikkaus. Laskuri pitää huolen, että vain kahta buttonia voidaan painaa kerrallaan
        count += 1

    #Katsotaan ovatko katsotut numerot samat eli löytyikö pari
    if len(ans_list) == 2:
        if pairs[ans_list[0]] == pairs[ans_list[1]]:
            game_label.config(text="Löysit parin!")
            pairs_found += 1
            # if pairs_found == 8:
            #     messagebox.showinfo("VOITIT" "Löysit kaikki parit!" "Sinulla meni aikaa:")
            #Jos pari löytyi laitetaan buttonit disabled-tilaan, jotta niitä ei voida enää painaa
            for key in ans_dict:
                key["state"] = DISABLED
            #Nollataan laskuri, lista ja dictionary
            count = 0
            ans_list = []
            ans_dict = {}
        else:
            count = 0
            ans_list = []
            for key in ans_dict:
                key["text"] = ''
            ans_dict = {}
            game_label.config(text="")

#Määritetään jokaiselle numerolle omat buttonit
button0 = Button(game_frame, text='', font=("Verdana", 20), fg="white", bg="black", height=3, width=6, command=lambda: [button_click(button0, 0)])
button1 = Button(game_frame, text='', font=("Verdana", 20), fg="white", bg="black", height=3, width=6, command=lambda: [button_click(button1, 1)])
button2 = Button(game_frame, text='', font=("Verdana", 20), fg="white", bg="black", height=3, width=6, command=lambda: [button_click(button2, 2)])
button3 = Button(game_frame, text='', font=("Verdana", 20), fg="white", bg="black", height=3, width=6, command=lambda: [button_click(button3, 3)])
button4 = Button(game_frame, text='', font=("Verdana", 20), fg="white", bg="black", height=3, width=6, command=lambda: [button_click(button4, 4)])
button5 = Button(game_frame, text='', font=("Verdana", 20), fg="white", bg="black", height=3, width=6, command=lambda: [button_click(button5, 5)])
button6 = Button(game_frame, text='', font=("Verdana", 20), fg="white", bg="black", height=3, width=6, command=lambda: [button_click(button6, 6)])
button7 = Button(game_frame, text='', font=("Verdana", 20), fg="white", bg="black", height=3, width=6, command=lambda: [button_click(button7, 7)])
button8 = Button(game_frame, text='', font=("Verdana", 20), fg="white", bg="black", height=3, width=6, command=lambda: [button_click(button8, 8)])
button9 = Button(game_frame, text='', font=("Verdana", 20), fg="white", bg="black", height=3, width=6, command=lambda: [button_click(button9, 9)])
button10 = Button(game_frame, text='', font=("Verdana", 20), fg="white", bg="black", height=3, width=6, command=lambda: [button_click(button10, 10)])
button11 = Button(game_frame, text='', font=("Verdana", 20), fg="white", bg="black", height=3, width=6, command=lambda: [button_click(button11, 11)])
button12 = Button(game_frame, text='', font=("Verdana", 20), fg="white", bg="black", height=3, width=6, command=lambda: [button_click(button12, 12)])
button13 = Button(game_frame, text='', font=("Verdana", 20), fg="white", bg="black", height=3, width=6, command=lambda: [button_click(button13, 13)])
button14 = Button(game_frame, text='', font=("Verdana", 20), fg="white", bg="black", height=3, width=6, command=lambda: [button_click(button14, 14)])
button15 = Button(game_frame, text='', font=("Verdana", 20), fg="white", bg="black", height=3, width=6, command=lambda: [button_click(button15, 15)])

#Määritetään buttoneiden paikat
button0.grid(row=0, column=0)
button1.grid(row=0, column=1)
button2.grid(row=0, column=2)
button3.grid(row=0, column=3)

button4.grid(row=1, column=0)
button5.grid(row=1, column=1)
button6.grid(row=1, column=2)
button7.grid(row=1, column=3)

button8.grid(row=2, column=0)
button9.grid(row=2, column=1)
button10.grid(row=2, column=2)
button11.grid(row=2, column=3)

button12.grid(row=3, column=0)
button13.grid(row=3, column=1)
button14.grid(row=3, column=2)
button15.grid(row=3, column=3)

game_label = Label(root, text='', font=("Verdana", 20))
game_label.pack()

root.mainloop()
peli2.py
6 kt