from tkinter import *
from tkinter import messagebox
from db import Database

db = Database('store.db')

def populate_list():
    parts_list.delete(0, END)
    for row in db.fetch():
        parts_list.insert(END, row)
#test
def add_item():
    if isyeri_text.get() == '' or btNo_text.get() == '' or gelisNedeni_text.get() == '' or yapilanIslem_text.get() == '' or gelisTarihi_text.get() == '' or teslimTarihi_text.get() == '':
        messagebox.showerror('Zorunlu Alanlar', 'Lütfen Bilgileri Eksiksiz Giriniz')
        return
    db.insert(isyeri_text.get(), btNo_text.get(), gelisNedeni_text.get(), yapilanIslem_text.get(), gelisTarihi_text.get(), teslimTarihi_text.get())
    parts_list.delete(0, END)
    parts_list.insert(END, (isyeri_text.get(), btNo_text.get(), gelisNedeni_text.get(), yapilanIslem_text.get(), gelisTarihi_text.get(), teslimTarihi_text.get()))
    clear_text()
    populate_list()

def select_item(event):
    try:
        global selected_item
        index = parts_list.curselection()[0]
        selected_item = parts_list.get(index)
        
        isyeri_entry.delete(0, END)
        isyeri_entry.insert(END, selected_item[1])
        btNo_entry.delete(0, END)
        btNo_entry.insert(END, selected_item[2])
        gelisNedeni_entry.delete(0, END)
        gelisNedeni_entry.insert(END, selected_item[3])
        yapilanIslem_entry.delete(0, END)
        yapilanIslem_entry.insert(END, selected_item[4])
        gelisTarihi_entry.delete(0, END)
        gelisTarihi_entry.insert(END, selected_item[5])
        teslimTarihi_entry.delete(0, END)
        teslimTarihi_entry.insert(END, selected_item[6])
    except IndexError:
        pass



def remove_item():
    db.remove(selected_item[0])
    clear_text()
    populate_list()

def update_item():
    db.update(selected_item[0],isyeri_text.get(), btNo_text.get(), gelisNedeni_text.get(), yapilanIslem_text.get(), gelisTarihi_text.get(), teslimTarihi_text.get())
    populate_list()

def clear_text():
    isyeri_entry.delete(0, END)
    btNo_entry.delete(0, END)
    gelisNedeni_entry.delete(0, END)
    yapilanIslem_entry.delete(0, END)
    gelisTarihi_entry.delete(0, END)
    teslimTarihi_entry.delete(0, END)

app = Tk()

isyeri_text = StringVar()
isyeri_label = Label(app, text='İşyeri Adı ', font=('bold', 14), pady = 20)
isyeri_label.grid(row=0, column=0, sticky=W)
isyeri_entry = Entry(app, textvariable=isyeri_text)
isyeri_entry.grid(row=0, column=1)

btNo_text = StringVar()
btNo_label = Label(app, text='Bt No ', font=('bold', 14))
btNo_label.grid(row=1, column=0, sticky=W)
btNo_entry = Entry(app, textvariable=btNo_text)
btNo_entry.grid(row=1, column=1)

gelisNedeni_text = StringVar()
gelisNedeni_label = Label(app, text='Geliş Nedeni ', font=('bold', 14))
gelisNedeni_label.grid(row=0, column=2, sticky=W)
gelisNedeni_entry = Entry(app, textvariable=gelisNedeni_text)
gelisNedeni_entry.grid(row=0, column=3)

yapilanIslem_text = StringVar()
yapilanIslem_label = Label(app, text='Yapılan İşlem ', font=('bold', 14))
yapilanIslem_label.grid(row=1, column=2, sticky=W)
yapilanIslem_entry = Entry(app, textvariable=yapilanIslem_text)
yapilanIslem_entry.grid(row=1, column=3)

gelisTarihi_text = StringVar()
gelisTarihi_label = Label(app, text='Geliş Tarihi ', font=('bold', 14))
gelisTarihi_label.grid(row=0, column=4, sticky=W)
gelisTarihi_entry = Entry(app, textvariable=gelisTarihi_text)
gelisTarihi_entry.grid(row=0, column=5)

teslimTarihi_text = StringVar()
teslimTarihi_label = Label(app, text='Teslim Tarihi ', font=('bold', 14))
teslimTarihi_label.grid(row=1, column=4, sticky=W)
teslimTarihi_entry = Entry(app, textvariable=teslimTarihi_text)
teslimTarihi_entry.grid(row=1, column=5)

parts_list = Listbox(app, height=8, width=90, border=0)
parts_list.grid(row=3, column=0, columnspan=6, rowspan=6, pady=20, padx=20)

scrollbar = Scrollbar(app)
scrollbar.grid(row=3, column=6)

parts_list.configure(yscrollcommand=scrollbar.set)
scrollbar.configure(command=parts_list.yview)

parts_list.bind('<<ListboxSelect>>', select_item)

add_btn = Button(app, text='Cihaz Ekle ', width=12, command=add_item)
add_btn.grid(row=2, column=0, pady=20)

remove_btn = Button(app, text='Cihazı Kaldır ', width=12, command=remove_item)
remove_btn.grid(row=2, column=1)

update_btn = Button(app, text='Cihazı Güncelle', width=12, command=update_item)
update_btn.grid(row=2, column=2)

clear_btn = Button(app, text='Temizle', width=12, command=clear_text)
clear_btn.grid(row=2, column=3)

app.title('Cihaz Takip Programi')
app.geometry('930x350')

populate_list()

app.mainloop()
