# ETP

## Adattárolás

### Definíciók
- **változó:** memóriaterület, amelyben érték tárolható
- **deklaráció:** változó számára memória lefoglalása, pl.: ```int i;```
- **értékadás:** meglévõ változó értékének megváltoztatása pl.: ```i = 5;```
- **inicializálás:** változó létrehozása és értékadása egy lépésben, pl.: ```int i = 5;```
- **literál:** kódba írt érték
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

## Vezérlési szerkezetek
1. **Szekvencia:** utasítások egymás után
2. **Elágazás:** feltételhez kötött utasítások
3. **Ciklus:** feltételhez kötött ismétlés

### Elágazás
#### if
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

#### switch-case
**Értékvizsgálat esetén**
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

### Ciklus
|név|jelölés|funkció|
|:---:|:---:|:---:|
|elõltesztelõ ciklus|while (feltétel) {}|addig ismétli, amíg a feltétel igaz|
|hátultesztelõ ciklus|do {} while (feltétel);|legalább egyszer lefut, majd addig ismétli, amíg a feltétel igaz|
|számláló|for (kezdõérték; feltétel; lépték) {}|addig ismétli, amíg a feltétel igaz|
|bejárás|foreach (változó in tömb) {}|végigmegy egy gyûjtemény elemein|

while
```csharp
while(logikai feltétel)
{
	// ciklusmag
}
```

számláló
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

hátultesztelõ ciklus
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

bejárás

```csharp
int[] tömb = { 1, 2, 3 };
foreach (var i in tömb)
{
	// ciklusmag
}
```
