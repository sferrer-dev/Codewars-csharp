# 🌐 IPv4 to Int32

![Codewars](https://img.shields.io/badge/Codewars-6kyu-red)
![Language](https://img.shields.io/badge/Language-C%23-blue)
![Framework](https://img.shields.io/badge/.NET-8.0-purple)

## 📘 Description

Une adresse **IPv4** est composée de **4 octets** séparés par des points :

```

A.B.C.D

```

Chaque octet correspond à **1 byte (8 bits)** et peut prendre une valeur comprise entre **0 et 255**.

Ainsi, une adresse IPv4 contient **32 bits au total**.

Dans ce kata, vous devez écrire une fonction capable de **convertir une adresse IPv4 en un entier 32 bits**.

🔗 **Kata Codewars**  
https://www.codewars.com/kata/52ea928a1ef5cfec800003ee

<p align="center">• • •</p>

## ⚙️ Objectif

Écrire une fonction :

```

ipToInt32

```

qui :

1. prend en entrée une **adresse IPv4 sous forme de chaîne de caractères**
2. convertit cette adresse en **entier non signé de 32 bits**
3. retourne la valeur numérique correspondante

<p align="center">• • •</p>

## 🧠 Principe

Chaque partie de l'adresse IPv4 correspond à **8 bits**.

Prenons l'exemple suivant :

```

128.32.10.1

```

Les octets et leur représentation binaire :

| Octet | Valeur | Binaire |
|------|------|------|
| 1 | 128 | 10000000 |
| 2 | 32 | 00100000 |
| 3 | 10 | 00001010 |
| 4 | 1 | 00000001 |

En combinant les quatre octets :

```

10000000.00100000.00001010.00000001

```

Ce qui correspond au nombre entier :

```

2149583361

```

<p align="center">• • •</p>

## 🧩 Exemple

### Entrée

```

"128.32.10.1"

```

### Résultat

```

2149583361

```

<p align="center">• • •</p>

## 🧠 Méthode de calcul

Pour convertir une adresse IPv4 en entier 32 bits, on peut utiliser la formule suivante :

```

result =
(A × 256³) +
(B × 256²) +
(C × 256¹) +
(D × 256⁰)

```

où :

```

A.B.C.D

```

sont les quatre octets de l'adresse IP.

Une autre approche consiste à utiliser des **opérations sur les bits (bit shifting)** :

```

(A << 24) | (B << 16) | (C << 8) | D

````

<p align="center">• • •</p>

## 🧩 Exemple d’utilisation

```csharp
IPv4Converter.IpToInt32("128.32.10.1");
````

Résultat :

```
2149583361
```

<p align="center">• • •</p>

## 🧪 Tests

Les tests unitaires sont disponibles dans le projet :

- 📁 [Projet de tests NUnit](../../../tests/6kyu/IPv4ToInt32.Tests/)

Les tests doivent vérifier notamment :

* la conversion correcte d'adresses IPv4
* plusieurs combinaisons d'octets
* les valeurs limites (`0.0.0.0`, `255.255.255.255`)
* la précision du calcul sur 32 bits

<p align="center">• • •</p>

## 🧠 Concepts abordés

Ce kata permet de travailler plusieurs notions importantes :

* manipulation d'adresses IP
* représentation binaire
* opérations sur les bits
* calculs sur des entiers 32 bits
* conversion entre différentes bases numériques

<p align="center">• • •</p>

## 🏷️ Catégories

* Networks
* Algorithms
* Bits
* Binary
* Fundamentals

<p align="center">• • •</p>

## 🧾 Résumé

Ce kata consiste à **convertir une adresse IPv4 en entier 32 bits**.

La fonction doit :

* analyser les **4 octets de l'adresse**
* convertir leur représentation binaire
* produire le **nombre entier équivalent sur 32 bits**.
