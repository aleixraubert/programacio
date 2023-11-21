# Ex2 Activitats - M05 

> *Autor:* **Aleix Raubert Rusiñol**

### 2 - Crea un document .md en el directori de la solució ([exercicis 1 i 2](https://docs.google.com/document/d/1EUhEMvn34CS3Cm1GuCI6h-WD60Kfcu3SwdaH4ckh-jQ/edit?usp=sharing)) i indica els següents punts amb les seves respostes:

#### a) Proves funcionals: classes d'equivalència, els valors límit corresponents i exemples de classes vàlides i classes invàlides

<span style="color: blue;">*Exercici 1*</span> 

```
using System;

namespace Testing
{
    public class Validate
    {
        public static void Main()
        {
            const string Msg = "Introdueix un valor natural";
            const string Msg2 = "Introdueix un altre valor natural";
            int num, num2;

            Console.WriteLine(Msg);

            num = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(Validate.IsPositive(num));

            Console.WriteLine(Msg2);

            num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(Validate.IsPositive(num2));

            Bigger(num, num2);
        }

        public static bool IsPositive(int num)
        {
            return num > 0;
        }

        public static void Bigger(int num, int num2)
        {
            if (num == num2) Console.WriteLine("Equals");
            else if (num > num2) Console.WriteLine($"{num} és el més gran.");
            else Console.WriteLine($"{num2} és el més gran.");
        }
    }
}
```


> Valors Límits: 
>: num: **MAX** (*2147483647*) // **MIN** (*1*)
>: num2: **MAX** (*2147483647*) // **MIN** (*1*)

> **Classes d'Equivalència**
>
> num:
>: Clase Vàlida: <span style="color: green; font-weight: bold;">*5, 4, 78, 90*</span>
>: Clase Invàlida: <span style="color: red; font-weight: bold;">*-4, 3.2, 0, 5.5*</span>
>
> num2:
>: Clase Vàlida: <span style="color: green; font-weight: bold;">*3, 1, 58, 82*</span>
>: Clase Invàlida: <span style="color: red; font-weight: bold;">*-3, 2.2, -2, 7.5*</span>

---
---

<span style="color: blue;">*Exercici 2*</span> 

```
using System;

namespace Testing
{
    public class Validate
    {
        public static void Main()
        {
            const string MSG = "Introdueix la base seguit del exponent.";

            int num, power;

            Console.WriteLine(MSG);

            num = Convert.ToInt32(Console.ReadLine());
            power = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(Potencia(num, power));
        }


        public static double Potencia(int num, int power)
        {
            return Math.Pow(num, power);
        }
    }
}
```

> Valors Límits: 
>: num: **MAX** (*2147483647*) // **MIN** (*-2147483647*)
>: power: **MAX** (*2147483647*) // **MIN** (*-2147483647*)

> **Classes d'Equivalència**
>
> num:
>: Clase Vàlida: <span style="color: green; font-weight: bold;">*5, 4, 78, 0*</span>
>: Clase Invàlida: <span style="color: red; font-weight: bold;">*4.4, 3.2, 1.1*</span>
>
> power:
>: Clase Vàlida: <span style="color: green; font-weight: bold;">*3, 1, 0, 82*</span>
>: Clase Invàlida: <span style="color: red; font-weight: bold;">*-3.23, 2.2, 7.5*</span>


---
#### b) Proves estructurals: implementa un projecte de test amb les seves respectives proves unitàries i enumera-les en el document. Un cop finalitzat, indica quin tipus de proves has realitzat (amb els resultats esperats i els resultats obtinguts).

<span style="color: blue;">*Exercici 1*</span>

>Test 1:
>: Input: <span style="color: orange; font-weight: bold;">9, 2</span>

>Resultat Esperat:
>: Intorudeix un valor natural. <span style="color: green; font-weight: bold;">TRUE</span>
>: Introdueix un altre valor natural.<span style="color: green; font-weight: bold;">TRUE</span>
>: 9 és el més gran.
>
>Resultat obtingut: 
>: Intorudeix un valor natural. <span style="color: green; font-weight: bold;">TRUE</span>
>: Introdueix un altre valor natural. <span style="color: green; font-weight: bold;">TRUE</span>
>: 9 és el més gran. 

---

>Test 2:
>: Input: <span style="color: orange; font-weight: bold;">9, -4</span>

>Resultat Esperat:
>: Intorudeix un valor natural.<span style="color: green; font-weight: bold;">TRUE</span>
>: Introdueix un altre valor natural. <span style="color: red; font-weight: bold;">FALSE</span>
>: 9 és el més gran.
>
>Resultat obtingut: 
>: Intorudeix un valor natural. <span style="color: green; font-weight: bold;">TRUE</span>
>: Introdueix un altre valor natural. <span style="color: red; font-weight: bold;">FALSE</span>
>: 9 és el més gran. 

---

>Test 3:
>: Input: <span style="color: orange; font-weight: bold;">9, 9</span>

>Resultat Esperat:
>: Intorudeix un valor natural. <span style="color: green; font-weight: bold;">TRUE</span>
>: Introdueix un altre valor natural. <span style="color: green; font-weight: bold;">TRUE</span>
>: Equals
>
>Resultat obtingut: 
>: Intorudeix un valor natural. <span style="color: green; font-weight: bold;">TRUE</span>
>: Introdueix un altre valor natural. <span style="color: green; font-weight: bold;">TRUE</span>
>: Equals

---

>Test 4:
>: Input: <span style="color: orange; font-weight: bold;">0.43, 2</span>

>Resultat Esperat:
>: Error al programa.
>
>Resultat obtingut: 
>: System.FormatException: 'The input string '0.5' was not in a correct format.

---
---

<span style="color: blue;">*Exercici 2*</span>

>Test 1:
>: Input: <span style="color: orange; font-weight: bold;">2, 4</span>

>Resultat Esperat:
>: 16
>
>Resultat obtingut: 
>: 16

---

>Test 2:
>: Input: <span style="color: orange; font-weight: bold;">4, -2</span>

>Resultat Esperat:
>: 0.0625
>
>Resultat obtingut: 
>: 0.0625

---

>Test 3:
>: Input: <span style="color: orange; font-weight: bold;">2, 0</span>

>Resultat Esperat:
>: 1
>
>Resultat obtingut: 
>: 1

---

>Test 4:
>: Input: <span style="color: orange; font-weight: bold;">0, 5</span>

>Resultat Esperat:
>: 0
>
>Resultat obtingut: 
>: 0

---

>Test 5:
>: Input: <span style="color: orange; font-weight: bold;">0.43, 2</span>

>Resultat Esperat:
>: Error al programa.
>
>Resultat obtingut: 
>: System.FormatException: 'The input string '0.5' was not in a correct format.

---