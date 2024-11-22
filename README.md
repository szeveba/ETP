# ETP

## Adatt�rol�s

### Defin�ci�k
- **v�ltoz�:** mem�riater�let, amelyben �rt�k t�rolhat�
- **deklar�ci�:** v�ltoz� sz�m�ra mem�ria lefoglal�sa, pl.: ```int i;```
- **�rt�kad�s:** megl�v� v�ltoz� �rt�k�nek megv�ltoztat�sa pl.: ```i = 5;```
- **inicializ�l�s:** v�ltoz� l�trehoz�sa �s �rt�kad�sa egy l�p�sben, pl.: ```int i = 5;```
- **liter�l:** k�dba �rt �rt�k
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

## Vez�rl�si szerkezetek
1. **Szekvencia:** utas�t�sok egym�s ut�n
2. **El�gaz�s:** felt�telhez k�t�tt utas�t�sok
3. **Ciklus:** felt�telhez k�t�tt ism�tl�s

### El�gaz�s
#### if
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

#### switch-case
**�rt�kvizsg�lat eset�n**
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

### Ciklus
|n�v|jel�l�s|funkci�|
|:---:|:---:|:---:|
|el�ltesztel� ciklus|while (felt�tel) {}|addig ism�tli, am�g a felt�tel igaz|
|h�tultesztel� ciklus|do {} while (felt�tel);|legal�bb egyszer lefut, majd addig ism�tli, am�g a felt�tel igaz|
|sz�ml�l�|for (kezd��rt�k; felt�tel; l�pt�k) {}|addig ism�tli, am�g a felt�tel igaz|
|bej�r�s|foreach (v�ltoz� in t�mb) {}|v�gigmegy egy gy�jtem�ny elemein|

while
```csharp
while(logikai felt�tel)
{
	// ciklusmag
}
```

sz�ml�l�
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

h�tultesztel� ciklus
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

bej�r�s

```csharp
int[] t�mb = { 1, 2, 3 };
foreach (var i in t�mb)
{
	// ciklusmag
}
```
