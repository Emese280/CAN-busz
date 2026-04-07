#CAN-busz felhasználói dokumentáció
Ez a program képes kategorizálni nagy mennyiségű CAN-busz járművek adatait, és szétválasztai az egybefolyó adatokat egymástól.

##Rendszerkövetelmények:
-Win10/11
-.NET10.0
-signals.txt fájl

##A szoftver használata:
Indítsa el a programot, amely ezután megmutatja az adatokat amiket le tud olvasni.
signals.txt fájl elemzése.
Konzolosan jeleníti meg az adatokat.




#Tesztelési jegyzőkönyv:
-Ha a program nem találja a fájlt, sárga színnel írja ki a konzolba a problémát: Error: file not found!
-Ha fájlbeolvasásnál kicserélem az értékeket, vagy elveszek belőlük: Unexpected error: The input string 'VehicleSpeed' was not in a correct format.
-A program működőképes állapotban kiírja a konzolra az adatokat ;-vel elválasztva egymástól őket. 

##Fejleszthető részek:
Kritikus adatokat pirosan jelenítsen meg, true és false értékeket más színekkel irasson ki. Fájlban lévő adatok bővítése adatokkal.
