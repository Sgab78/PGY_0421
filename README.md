# PGY_0421 

### Leírás
CSharp Form készítés

A "megrendel" gomb feladata:
összesítse az adatokat, melyeket a felhasználó választ ki.
írja ki egy "rendelés.txt"-be, hogy miket választott ki a felhasználó

Ha a felhasználó nem használ feltétet vagy "SAJT"-ot, akkor nem rendelhet
Ha a felhasználó 3-nál több feltétet választana ki, akkor figyelmeztessük, hogy nem rendelhet egyszerre annyit.
A felhasználó alert-ek segítségével kommunikáljunk.

### Terv
**- felület elkészítése**
**- Esetlegesen a több mint 3 feltétel lekezelése, a feltétel kiválasztásakor**
**- "megrendel" funkció**
  - validálás
    - legalább 1 feltét vagy sajt
    - ha nem kezeltük le a 3-nál több feltétet, akkor itt kell
  - ki íratás fájlba
