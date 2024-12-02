# ETP

## Adattárolás

### Definíciók
- **változó:** memóriaterület, amelyben érték tárolható
- **deklaráció:** változó számára memória lefoglalása, pl.: ```int i;```
- **értékadás:** meglévõ változó értékének megváltoztatása pl.: ```i = 5;```
- **inicializálás:** változó létrehozása és értékadása egy lépésben, pl.: ```int i = 5;```
- **literál:** kódba írt érték, pl.: `"asd"`,`'c'`,`1`,`13.15`,`true`
- **kifejezés:** literálok, változók és operátorok felhasználásával kifejezett érték

### Használat
Változókban tudunk értékeket eltárolni.
Változó létrehozása: 
(változó típusa) (változó neve) = (literál vagy kifejezés);

- számok (egész, valós)
- karakter
- karakterlánc
- logikai

|név|típus|literál|változó|
|:---:|:---:|:---:|:---:|
|egész|int|13|int i = 0;|
|valós|double|3.14|double d = 3.14;|
|karakter|char|'a'|char c = 'b';|
|karakterlánc|string|"asd"|string s = "asd";|
|logikai|bool|true, false|bool b = false;|

```csharp
int a = 5;
string valami = "szia";
var változó = 3.14; // fordító tudja, hogy double
// változó inicializálása kifejezéssel
int i = a + 3;
```

### Tömb
- **tömb:** azonos típusú változók sorozata
- **index:** a tömb egy elemének pozíciója (0-tól kezdõdik)

(változók típusa)[] (tömb neve) = new (változó típusa)[darabszám];

```csharp
int[] tömb1 = new int[3]; 
tömb[0] = 1;
tömb[1] = 2;
tömb[2] = 3;
// elemek felsorolásával
int[] tömb2 = { 1, 2, 3 };
```
## Típuskonverziók
### Karakterláncból szám
#### Valós szám esetén
```csharp
string input = "5.6";
double number = double.Parse(input);
```
#### Egész szám estén
```csharp
string input = "13";
int number = int.Parse(input);
```
### Karakterláncból karakter kiválasztása
A string tömbszerûen indexelhetõ.
```csharp
string input = "5.6";
Console.WriteLine(input[1]) //kimenet: .
```
### Védekezés az átalakítás körüli hibáktól
#### try-catch blokk
```csharp
try
{
    string input = "asd"
    int szam = int.Parse(input);
    //... folytatódik a végrehajtás ha nincs átalakítási probléma
}
catch (Exception)
{
	// ha probléma adódott átugrik a vezérlés a legpontosabban illeszkedõ catch ágba
    Console.WriteLine("Hibás a bemenet amit adtál, csak számot adhatsz meg!");
}
```

#### TryParse
```csharp
public static int ReadInt(string message)
{
    int result;
    Console.Write(message);
    string? input = Console.ReadLine();
    while (!int.TryParse(input, out result))
    {
        Console.WriteLine("Átalakítás sikertelen, megadott hibás érték: "+input);
        Console.Write(message);
    }
    return result;
}
```

## Operátorok
- **operátor:** mûvelei jel
- **operandus:** mûvelet részét képzõ adat
- **unáris:** egy operandusú
- **bináris:** két operandusú
- **ternáris:** három operandusú

|Operátor|Mûvelet|Példa|
|:---:|:---:|:---:|
|=|értékadás|a = 3|
|+|összeadás,string összefûzés|1 + b; 123 + "asd" == "123asd"|
|-|kivonás|a - 2|
|*|szorzás|3 * c|
|/|osztás|5 / 2 == 2; 5.0 / 2 == 2.5|
|%|maradékos osztás|5 % 2 == 1|
|++|inkrementálás|a++|
|--|dekrementálás|b--|
|+=|összeadás rövidítve|a += 3;|
|-=|kivonás rövidítve|b -= 2;|
|*=|szorzás rövidítve|c *= 3;|
|/=|osztás rövidítve|d /= 2;|
|%=|maradékos osztás rövidítve|e %= 3;|
|==|egyenlõség|a == b|
|!=|nem egyenlõség|a != b|
|<|kisebb|a < b|
|>|nagyobb|a > b|
|<=|kisebb vagy egyenlõ|a <= b|
|>=|nagyobb vagy egyenlõ|a >= b|
|&&|és|a && b|
|\|\||vagy|a \|\| b|
|!|nem|!(a == b)|
|?:|ternary operator|a > b ? a : b|

## Vezérlési szerkezetekek

Az utasítások sorrendjét befolyásoló szerkezetek:

1. **Szekvencia:** utasítások egymás után
2. **Elágazás:** feltételhez kötött utasítások
3. **Ciklus:** feltételhez kötött ismétlés

### Elágazás
#### Feltételvizsgálat esetén (if)

```csharp
if (logikai feltétel)
{
	// ha igaz
}
else
{
	// ha hamis
}
// ha csak egy utasítás van, akkor a kapcsos zárójelek elhagyhatók

if (logikai feltétel) Console.WriteLine("Igaz");
else Console.WriteLine("Hamis");
```

#### Értékvizsgálat esetén (switch-case)

```csharp
switch (változó)
{
	case érték1:
		// ha érték1
		break;
	case érték2:
		// ha érték2
		break;
	default:
		// ha egyik sem
		break;
}

if (változó == érték1) // ha érték1
else if (változó == érték2) // ha érték2
else // ha egyik sem
```

**Esetek összevonása**
```csharp
switch (változó)
{
	case érték1:
	case érték2:
		// ha érték1 vagy érték2
		break;
	default:
		// ha egyik sem
		break;
	}
```

### Ciklusok
|név|jelölés|funkció|
|:---:|:---:|:---:|
|elõltesztelõ ciklus|while (feltétel) {}|addig ismétli, amíg a feltétel igaz|
|hátultesztelõ ciklus|do {} while (feltétel);|legalább egyszer lefut, majd addig ismétli, amíg a feltétel igaz|
|számláló|for (kezdõérték; feltétel; lépték) {}|addig ismétli, amíg a feltétel igaz|
|bejárás|foreach (változó in tömb) {}|végigmegy egy gyûjtemény elemein|

#### Elõltesztelõ ciklus (while)
```csharp
while(logikai feltétel)
{
	// ciklusmag
}
```

#### Számláló (for)
```csharp
for (int i = 0; i < 10; i++)
{
	// ciklusmag
}

//for kifejezése while-al
int i = 0;
while (i < 10)
{
	// ciklusmag
	i++;
}

// inkrementálás dekrementálás sorrendje
int a = 0;
int b = 3;
int c = a++; // c = 0, a = 1
c = --b; // b = 2, c = 2
```

#### Hátultesztelõ ciklus (do-while)
```csharp
do
{
	// ciklusmag
} while (logikai feltétel);

// do-while kifejezése while-al

// ciklusmag
while (logikai feltétel){
	// ciklusmag
}
```

#### Bejáró ciklus (foreach)

```csharp
int[] tömb = { 1, 2, 3 };
foreach (var i in tömb)
{
	// ciklusmag
}
```

## Fejlesztõkörnyezet
- **Visual Studio:** Microsoft által fejlesztett IDE (Integrated Development Environment)
- **C#:** Microsoft által fejlesztett programozási nyelv
- **.NET:** Microsoft által fejlesztett keretrendszer fõleg C#-hoz
- **Solution:** egy vagy több projektet tartalmazó munkaterület (.sln fájl)
- **Projekt:** egy alkalmazás vagy könyvtár (.csproj fájl)
- **Solution Explorer:** megjeleníti a megnyitott solution elemeit

Nézetek megnyitása esetén: Ctrl + Q: Feature search

## Program felépítése
- **Felhasználói felület:** amin keresztül tud interaktálni a felhasználó a programmal
- **Üzleti logika:** a program mûködését meghatározó rész
- **Adatelérés:** adatok lekérdezése, módosítása, törlése

## Konzol
- **Console:** a konzolablakot reprezentáló osztály
- **WriteLine:** kiír egy sort a konzolra majd egy sortörést tesz
- **Write:** kiír egy sort a konzolra, de nem tesz utána sortörést
- **ReadLine:** beolvassa a felhasználó által beírt sort (Enter lenyomásáig)
- **ReadKey:** beolvassa a felhasználó által lenyomott billentyût
- **Clear:** törli a konzol tartalmát
- **ForegroundColor:** a konzol szövegének színe
- **BackgroundColor:** a konzol háttérszínének színe
- **CursorVisible:** a kurzor láthatósága
- **CursorLeft:** kurzor vízszintes pozíciója
- **CursorTop:** kurzor függõleges pozíciója
- **SetCursorPosition:** kurzor pozíciójának beállítása
- **Title:** konzolablak címe
- **WindowWidth:** konzolablak szélessége (hány karakter)
- **WindowHeight:** konzolablak magassága (hány karakter)

## Math segédosztály
**Math:** matematikai mûveletek végrehajtására szolgáló osztály.
- **Round:** kerekítés
- **Pow:** hatványozás
- **Sqrt:** négyzetgyök
- **PI:** pi értéke
- **Abs:** abszolút érték
- **Ceiling:** felfelé kerekítés
- **Floor:** lefelé kerekítés
- **Max:** két szám közül a nagyobb
- **Min:** két szám közül a kisebb
- **Sin:** szinusz
- **Cos:** koszinusz
- **Tan:** tangens
- **Asin:** arcszinusz
- **Acos:** arccoszinusz
- **Atan:** arctangens
- **E:** e alapú logaritmus
- **Log:** logaritmus
- **Truncate:** törtrész eldobása

## Random számgenerálás
- **Random:** véletlenszám generálására szolgáló osztály
- Példányosítás utána a Next metódussal tudunk számot generálni
```csharp
Random random = new Random(); // inicializálás
random.Next(1, 10); // 1 és 10 közötti szám, a 10 már nem lesz benne a tartományban
```


- **Namespace:** névtér, osztályok csoportosítására szolgál, egy névtérben egy név csak egyszer használható
- **Class:** osztály, adattagok és metódusok összessége, pl.: Program osztály: ez szimbolizálja a kódunkban a programot magát
- **Main metódus:** a program belépési pontja, innen indul a program futása
- **Metódus:** egy osztály eljárása vagy függvénye, utasítások sorozatát tartalmazza, lehet bemenete paramétereken keresztül
