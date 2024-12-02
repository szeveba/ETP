# ETP

## Adatt�rol�s

### Defin�ci�k
- **v�ltoz�:** mem�riater�let, amelyben �rt�k t�rolhat�
- **deklar�ci�:** v�ltoz� sz�m�ra mem�ria lefoglal�sa, pl.: ```int i;```
- **�rt�kad�s:** megl�v� v�ltoz� �rt�k�nek megv�ltoztat�sa pl.: ```i = 5;```
- **inicializ�l�s:** v�ltoz� l�trehoz�sa �s �rt�kad�sa egy l�p�sben, pl.: ```int i = 5;```
- **liter�l:** k�dba �rt �rt�k, pl.: `"asd"`,`'c'`,`1`,`13.15`,`true`
- **kifejez�s:** liter�lok, v�ltoz�k �s oper�torok felhaszn�l�s�val kifejezett �rt�k

### Haszn�lat
V�ltoz�kban tudunk �rt�keket elt�rolni.
V�ltoz� l�trehoz�sa: 
(v�ltoz� t�pusa) (v�ltoz� neve) = (liter�l vagy kifejez�s);

- sz�mok (eg�sz, val�s)
- karakter
- karakterl�nc
- logikai

|n�v|t�pus|liter�l|v�ltoz�|
|:---:|:---:|:---:|:---:|
|eg�sz|int|13|int i = 0;|
|val�s|double|3.14|double d = 3.14;|
|karakter|char|'a'|char c = 'b';|
|karakterl�nc|string|"asd"|string s = "asd";|
|logikai|bool|true, false|bool b = false;|

```csharp
int a = 5;
string valami = "szia";
var v�ltoz� = 3.14; // ford�t� tudja, hogy double
// v�ltoz� inicializ�l�sa kifejez�ssel
int i = a + 3;
```

### T�mb
- **t�mb:** azonos t�pus� v�ltoz�k sorozata
- **index:** a t�mb egy elem�nek poz�ci�ja (0-t�l kezd�dik)

(v�ltoz�k t�pusa)[] (t�mb neve) = new (v�ltoz� t�pusa)[darabsz�m];

```csharp
int[] t�mb1 = new int[3]; 
t�mb[0] = 1;
t�mb[1] = 2;
t�mb[2] = 3;
// elemek felsorol�s�val
int[] t�mb2 = { 1, 2, 3 };
```
## T�puskonverzi�k
### Karakterl�ncb�l sz�m
#### Val�s sz�m eset�n
```csharp
string input = "5.6";
double number = double.Parse(input);
```
#### Eg�sz sz�m est�n
```csharp
string input = "13";
int number = int.Parse(input);
```
### Karakterl�ncb�l karakter kiv�laszt�sa
A string t�mbszer�en indexelhet�.
```csharp
string input = "5.6";
Console.WriteLine(input[1]) //kimenet: .
```
### V�dekez�s az �talak�t�s k�r�li hib�kt�l
#### try-catch blokk
```csharp
try
{
    string input = "asd"
    int szam = int.Parse(input);
    //... folytat�dik a v�grehajt�s ha nincs �talak�t�si probl�ma
}
catch (Exception)
{
	// ha probl�ma ad�dott �tugrik a vez�rl�s a legpontosabban illeszked� catch �gba
    Console.WriteLine("Hib�s a bemenet amit adt�l, csak sz�mot adhatsz meg!");
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
        Console.WriteLine("�talak�t�s sikertelen, megadott hib�s �rt�k: "+input);
        Console.Write(message);
    }
    return result;
}
```

## Oper�torok
- **oper�tor:** m�velei jel
- **operandus:** m�velet r�sz�t k�pz� adat
- **un�ris:** egy operandus�
- **bin�ris:** k�t operandus�
- **tern�ris:** h�rom operandus�

|Oper�tor|M�velet|P�lda|
|:---:|:---:|:---:|
|=|�rt�kad�s|a = 3|
|+|�sszead�s,string �sszef�z�s|1 + b; 123 + "asd" == "123asd"|
|-|kivon�s|a - 2|
|*|szorz�s|3 * c|
|/|oszt�s|5 / 2 == 2; 5.0 / 2 == 2.5|
|%|marad�kos oszt�s|5 % 2 == 1|
|++|inkrement�l�s|a++|
|--|dekrement�l�s|b--|
|+=|�sszead�s r�vid�tve|a += 3;|
|-=|kivon�s r�vid�tve|b -= 2;|
|*=|szorz�s r�vid�tve|c *= 3;|
|/=|oszt�s r�vid�tve|d /= 2;|
|%=|marad�kos oszt�s r�vid�tve|e %= 3;|
|==|egyenl�s�g|a == b|
|!=|nem egyenl�s�g|a != b|
|<|kisebb|a < b|
|>|nagyobb|a > b|
|<=|kisebb vagy egyenl�|a <= b|
|>=|nagyobb vagy egyenl�|a >= b|
|&&|�s|a && b|
|\|\||vagy|a \|\| b|
|!|nem|!(a == b)|
|?:|ternary operator|a > b ? a : b|

## Vez�rl�si szerkezetekek

Az utas�t�sok sorrendj�t befoly�sol� szerkezetek:

1. **Szekvencia:** utas�t�sok egym�s ut�n
2. **El�gaz�s:** felt�telhez k�t�tt utas�t�sok
3. **Ciklus:** felt�telhez k�t�tt ism�tl�s

### El�gaz�s
#### Felt�telvizsg�lat eset�n (if)

```csharp
if (logikai felt�tel)
{
	// ha igaz
}
else
{
	// ha hamis
}
// ha csak egy utas�t�s van, akkor a kapcsos z�r�jelek elhagyhat�k

if (logikai felt�tel) Console.WriteLine("Igaz");
else Console.WriteLine("Hamis");
```

#### �rt�kvizsg�lat eset�n (switch-case)

```csharp
switch (v�ltoz�)
{
	case �rt�k1:
		// ha �rt�k1
		break;
	case �rt�k2:
		// ha �rt�k2
		break;
	default:
		// ha egyik sem
		break;
}

if (v�ltoz� == �rt�k1) // ha �rt�k1
else if (v�ltoz� == �rt�k2) // ha �rt�k2
else // ha egyik sem
```

**Esetek �sszevon�sa**
```csharp
switch (v�ltoz�)
{
	case �rt�k1:
	case �rt�k2:
		// ha �rt�k1 vagy �rt�k2
		break;
	default:
		// ha egyik sem
		break;
	}
```

### Ciklusok
|n�v|jel�l�s|funkci�|
|:---:|:---:|:---:|
|el�ltesztel� ciklus|while (felt�tel) {}|addig ism�tli, am�g a felt�tel igaz|
|h�tultesztel� ciklus|do {} while (felt�tel);|legal�bb egyszer lefut, majd addig ism�tli, am�g a felt�tel igaz|
|sz�ml�l�|for (kezd��rt�k; felt�tel; l�pt�k) {}|addig ism�tli, am�g a felt�tel igaz|
|bej�r�s|foreach (v�ltoz� in t�mb) {}|v�gigmegy egy gy�jtem�ny elemein|

#### El�ltesztel� ciklus (while)
```csharp
while(logikai felt�tel)
{
	// ciklusmag
}
```

#### Sz�ml�l� (for)
```csharp
for (int i = 0; i < 10; i++)
{
	// ciklusmag
}

//for kifejez�se while-al
int i = 0;
while (i < 10)
{
	// ciklusmag
	i++;
}

// inkrement�l�s dekrement�l�s sorrendje
int a = 0;
int b = 3;
int c = a++; // c = 0, a = 1
c = --b; // b = 2, c = 2
```

#### H�tultesztel� ciklus (do-while)
```csharp
do
{
	// ciklusmag
} while (logikai felt�tel);

// do-while kifejez�se while-al

// ciklusmag
while (logikai felt�tel){
	// ciklusmag
}
```

#### Bej�r� ciklus (foreach)

```csharp
int[] t�mb = { 1, 2, 3 };
foreach (var i in t�mb)
{
	// ciklusmag
}
```

## Fejleszt�k�rnyezet
- **Visual Studio:** Microsoft �ltal fejlesztett IDE (Integrated Development Environment)
- **C#:** Microsoft �ltal fejlesztett programoz�si nyelv
- **.NET:** Microsoft �ltal fejlesztett keretrendszer f�leg C#-hoz
- **Solution:** egy vagy t�bb projektet tartalmaz� munkater�let (.sln f�jl)
- **Projekt:** egy alkalmaz�s vagy k�nyvt�r (.csproj f�jl)
- **Solution Explorer:** megjelen�ti a megnyitott solution elemeit

N�zetek megnyit�sa eset�n: Ctrl + Q: Feature search

## Program fel�p�t�se
- **Felhaszn�l�i fel�let:** amin kereszt�l tud interakt�lni a felhaszn�l� a programmal
- **�zleti logika:** a program m�k�d�s�t meghat�roz� r�sz
- **Adatel�r�s:** adatok lek�rdez�se, m�dos�t�sa, t�rl�se

## Konzol
- **Console:** a konzolablakot reprezent�l� oszt�ly
- **WriteLine:** ki�r egy sort a konzolra majd egy sort�r�st tesz
- **Write:** ki�r egy sort a konzolra, de nem tesz ut�na sort�r�st
- **ReadLine:** beolvassa a felhaszn�l� �ltal be�rt sort (Enter lenyom�s�ig)
- **ReadKey:** beolvassa a felhaszn�l� �ltal lenyomott billenty�t
- **Clear:** t�rli a konzol tartalm�t
- **ForegroundColor:** a konzol sz�veg�nek sz�ne
- **BackgroundColor:** a konzol h�tt�rsz�n�nek sz�ne
- **CursorVisible:** a kurzor l�that�s�ga
- **CursorLeft:** kurzor v�zszintes poz�ci�ja
- **CursorTop:** kurzor f�gg�leges poz�ci�ja
- **SetCursorPosition:** kurzor poz�ci�j�nak be�ll�t�sa
- **Title:** konzolablak c�me
- **WindowWidth:** konzolablak sz�less�ge (h�ny karakter)
- **WindowHeight:** konzolablak magass�ga (h�ny karakter)

## Math seg�doszt�ly
**Math:** matematikai m�veletek v�grehajt�s�ra szolg�l� oszt�ly.
- **Round:** kerek�t�s
- **Pow:** hatv�nyoz�s
- **Sqrt:** n�gyzetgy�k
- **PI:** pi �rt�ke
- **Abs:** abszol�t �rt�k
- **Ceiling:** felfel� kerek�t�s
- **Floor:** lefel� kerek�t�s
- **Max:** k�t sz�m k�z�l a nagyobb
- **Min:** k�t sz�m k�z�l a kisebb
- **Sin:** szinusz
- **Cos:** koszinusz
- **Tan:** tangens
- **Asin:** arcszinusz
- **Acos:** arccoszinusz
- **Atan:** arctangens
- **E:** e alap� logaritmus
- **Log:** logaritmus
- **Truncate:** t�rtr�sz eldob�sa

## Random sz�mgener�l�s
- **Random:** v�letlensz�m gener�l�s�ra szolg�l� oszt�ly
- P�ld�nyos�t�s ut�na a Next met�dussal tudunk sz�mot gener�lni
```csharp
Random random = new Random(); // inicializ�l�s
random.Next(1, 10); // 1 �s 10 k�z�tti sz�m, a 10 m�r nem lesz benne a tartom�nyban
```


- **Namespace:** n�vt�r, oszt�lyok csoportos�t�s�ra szolg�l, egy n�vt�rben egy n�v csak egyszer haszn�lhat�
- **Class:** oszt�ly, adattagok �s met�dusok �sszess�ge, pl.: Program oszt�ly: ez szimboliz�lja a k�dunkban a programot mag�t
- **Main met�dus:** a program bel�p�si pontja, innen indul a program fut�sa
- **Met�dus:** egy oszt�ly elj�r�sa vagy f�ggv�nye, utas�t�sok sorozat�t tartalmazza, lehet bemenete param�tereken kereszt�l
