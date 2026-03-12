# 🔤 Strings Mix

![Codewars](https://img.shields.io/badge/Codewars-4kyu-red)
![Language](https://img.shields.io/badge/Language-C%23-blue)
![Framework](https://img.shields.io/badge/.NET-8.0-purple)

## 📘 Description

Dans ce kata, l'objectif est de **comparer deux chaînes de caractères** afin de visualiser leurs différences en se basant uniquement sur les **lettres minuscules de `a` à `z`**.

L'idée consiste à :

1. compter le nombre d'occurrences de chaque lettre dans les deux chaînes
2. conserver uniquement les lettres dont la fréquence maximale est **strictement supérieure à 1**
3. produire une représentation textuelle indiquant **dans quelle chaîne la fréquence est la plus élevée**

🔗 **Kata Codewars**  
https://www.codewars.com/kata/5629db57620258aa9d000014

<p align="center">• • •</p>

## ⚙️ Règles

Soient deux chaînes :

```

s1
s2

```

On procède de la manière suivante :

1. **Ne considérer que les lettres minuscules `a..z`**
2. Compter leur fréquence dans `s1` et `s2`
3. Déterminer la fréquence maximale pour chaque lettre
4. Ignorer les lettres dont la fréquence maximale est **≤ 1**

Chaque groupe doit être préfixé selon l'origine de la fréquence maximale :

| Préfixe | Signification |
|---|---|
| `1:` | fréquence maximale dans `s1` |
| `2:` | fréquence maximale dans `s2` |
| `=:` | fréquence maximale identique dans `s1` et `s2` |

Chaque lettre est répétée **autant de fois que sa fréquence maximale**.

<p align="center">• • •</p>

## 🧠 Principe

Pour chaque lettre `a..z` :

```

freq1 = nombre d'occurrences dans s1
freq2 = nombre d'occurrences dans s2
max = max(freq1, freq2)

```

Si :

```

max > 1

```

alors on génère une sous-chaîne :

```

prefix + lettre répétée max fois

```

Exemples :

```

1:aaaa
2:bbb
=:ccc

```

<p align="center">• • •</p>

## 🔎 Tri du résultat

Les groupes obtenus doivent être triés selon les règles suivantes :

1️⃣ **ordre décroissant de longueur**

```

aaaa > bbb > cc

```

2️⃣ **ordre lexicographique croissant** si la longueur est identique

Le tri s'effectue en utilisant le **codepoint des caractères**.

Les groupes sont ensuite **séparés par `/`**.

<p align="center">• • •</p>

## 🧩 Exemple simple

### Entrée

```

s1 = "A aaaa bb c"
s2 = "& aaa bbb c d"

```

### Comptage

```

s1 : a = 4, b = 2, c = 1
s2 : a = 3, b = 3, c = 1, d = 1

```

On ignore les lettres dont la fréquence maximale est ≤ 1.

```

a -> max = 4 (s1)
b -> max = 3 (s2)

```

### Résultat

```

"1:aaaa/2:bbb"

```

<p align="center">• • •</p>

## 🧩 Exemple

### Entrée

```

s1 = "my&friend&Paul has heavy hats! &"
s2 = "my friend John has many many friends &"

```

### Résultat

```

"2:nnnnn/1:aaaa/1:hhh/2:mmm/2:yyy/2:dd/2:ff/2:ii/2:rr/=:ee/=:ss"

```

<p align="center">• • •</p>

## 🧩 Autre exemple

### Entrée

```

s1 = "Are the kids at home? aaaaa fffff"
s2 = "Yes they are here! aaaaa fffff"

```

### Résultat

```

"=:aaaaaa/2:eeeee/=:fffff/1:tt/2:rr/=:hh"

````

<p align="center">• • •</p>

## 🧩 Exemple d’utilisation

```csharp
MixStrings.Mix("A aaaa bb c", "& aaa bbb c d");
````

Résultat :

```
"1:aaaa/2:bbb"
```

<p align="center">• • •</p>

## 🧪 Tests

Les tests unitaires sont disponibles dans le projet :

- 📁 [Projet de tests NUnit](../../../tests/4kyu/StringsMix.Tests/)

Les tests doivent vérifier notamment :

* le comptage correct des fréquences
* la gestion des lettres minuscules uniquement
* l'exclusion des lettres avec fréquence ≤ 1
* la génération correcte des préfixes
* le tri correct du résultat

<p align="center">• • •</p>

## 🧠 Concepts abordés

Ce kata permet de travailler plusieurs notions importantes :

* manipulation de chaînes de caractères
* comptage de fréquences
* tri multi-critères
* structures de données (dictionnaires)
* algorithmes de comparaison

<p align="center">• • •</p>

## 🏷️ Catégories

* Fundamentals
* Strings

<p align="center">• • •</p>

## 🧾 Résumé

Ce kata consiste à **comparer deux chaînes de caractères** en analysant les fréquences des lettres minuscules.

La fonction doit :

* compter les occurrences des lettres `a..z`
* conserver uniquement celles apparaissant plus d'une fois
* indiquer dans quelle chaîne la fréquence est la plus élevée
* produire une représentation triée du résultat.
