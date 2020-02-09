import sqlite3


class Database:
    def __init__(self, db):
        self.conn = sqlite3.connect(db)
        self.cur = self.conn.cursor()
        self.cur.execute("CREATE TABLE IF NOT EXISTS parts (id INTEGER PRIMARY KEY, isyeri text, btNo text, gelisNedeni text, yapilanIslem text, gelisTarihi text, teslimTarihi text)")
        self.conn.commit()

    def fetch(self):
        self.cur.execute("SELECT * FROM parts")
        rows = self.cur.fetchall()
        return rows
    
    def insert(self, isyeri, btNo, gelisNedeni, yapilanIslem, gelisTarihi, teslimTarihi):
        self.cur.execute("INSERT INTO parts VALUES (NULL, ?, ?, ?, ?, ?, ?)", (isyeri, btNo, gelisNedeni, yapilanIslem, gelisTarihi, teslimTarihi))
        self.conn.commit()

    def remove(self, id):
        self.cur.execute("DELETE FROM parts WHERE id=?", (id,))
        self.conn.commit()

    def update(self, id, isyeri, btNo, gelisNedeni, yapilanIslem, gelisTarihi, teslimTarihi):
        self.cur.execute("UPDATE parts SET isyeri = ?, btNo = ?, gelisNedeni = ?, yapilanIslem = ?, gelisTarihi = ?, teslimTarihi = ? WHERE id = ?", (isyeri, btNo, gelisNedeni, yapilanIslem, gelisTarihi, teslimTarihi,id))
        self.conn.commit()

    def __del__(self):
        self.conn.close()

#db = Database('store.db')
#db.insert("Asus Mobo", "Mike Henry", "Microcenter", "360", "Microcsadsaenter", "1260")
#db.insert("500w PSU", "Karen Johnson", "Newegg", "80", "Microcentsadsfader", "1620")
#db.insert("2GB DDR4 Ram", "Karen Johnson", "Newegg", "70", "Microasddfcenter", "1610")
#db.insert("24 inch Samsung Monitor", "Sam Smith", "Best Buy", "180", "Mffwqicrocenter", "1660")
#db.insert("NVIDIA RTX 2080", "Albert Kingston", "Newegg", "679", "Microcewqwenter", "1650")
#db.insert("600w Corsair PSU", "Karen Johnson", "Newegg", "130", "Microcewqewqewnter", "16330")
