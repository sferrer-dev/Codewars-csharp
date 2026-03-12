# 🏛️ Roman Numerals Helper

![Codewars](https://img.shields.io/badge/Codewars-4kyu-purple)
![Language](https://img.shields.io/badge/Language-C%23-blue)
![Framework](https://img.shields.io/badge/.NET-8.0-purple)

## 📘 Description

Écrire deux fonctions permettant de **convertir un entier en chiffre romain** et **un chiffre romain en entier**.

Les **chiffres romains modernes** sont écrits en exprimant chaque valeur en partant du chiffre le plus à gauche et en utilisant les combinaisons standards.

Plage de valeurs :

```

1 ≤ n < 4000

```

🔗 **Kata Codewars** - [Roman Numerals Helper](https://www.codewars.com/kata/51b66044bce5799a7f000003)

<p align="center">• • •</p>

## ⚙️ Objectif

Implémenter deux méthodes :

- conversion **entier → chiffre romain**
- conversion **chiffre romain → entier**

Ces méthodes doivent respecter les règles modernes d’écriture des chiffres romains.

<p align="center">• • •</p>

## 📏 Règles des chiffres romains

Les chiffres romains utilisent les symboles suivants :

| Symbole | Valeur |
|-------|------|
| M | 1000 |
| CM | 900 |
| D | 500 |
| CD | 400 |
| C | 100 |
| XC | 90 |
| L | 50 |
| XL | 40 |
| X | 10 |
| IX | 9 |
| V | 5 |
| IV | 4 |
| I | 1 |

<p align="center">• • •</p>

## 💡 Principe

### Conversion entier → chiffre romain

Le principe consiste à **soustraire successivement les plus grandes valeurs possibles** et à ajouter les symboles correspondants.

Exemple :

```

1990
= 1000 + 900 + 90
= M + CM + XC
= MCMXC

```

Autre exemple :

```

2008
= 2000 + 8
= MM + VIII
= MMVIII

```

<p align="center">• • •</p>

### Conversion chiffre romain → entier

Le principe consiste à **parcourir les symboles et additionner leurs valeurs**.

Lorsque **un symbole plus petit précède un symbole plus grand**, on effectue une **soustraction**.

Exemple :

```

IV = 5 - 1 = 4
IX = 10 - 1 = 9

```

<p align="center">• • •</p>

## 🔎 Exemples

### Conversion entier → romain

| Entier | Résultat |
|------|------|
| 2000 | `"MM"` |
| 1666 | `"MDCLXVI"` |
| 86 | `"LXXXVI"` |
| 1 | `"I"` |

### Conversion romain → entier

| Romain | Résultat |
|------|------|
| `"MM"` | 2000 |
| `"MDCLXVI"` | 1666 |
| `"LXXXVI"` | 86 |
| `"I"` | 1 |

<p align="center">• • •</p>

## ⚠️ Particularité

Dans ce kata :

```

4 = IV

```

et **non**

```

IIII

```

Cette notation est appelée **notation soustractive**.

<p align="center">• • •</p>

## 🧪 Tests

Les tests unitaires associés sont disponibles dans le projet :

- 📁 [Projet de tests NUnit](../../../tests/4kyu/RomanNumeralsHelper.Tests/)

Les tests couvrent notamment :

- la **conversion entier → romain**
- la **conversion romain → entier**
- les **valeurs limites**
- différentes **combinaisons de symboles**

<p align="center">• • •</p>

## 🧾 Résumé

La solution doit :

- convertir **un entier en chiffre romain**
- convertir **un chiffre romain en entier**
- respecter les **règles modernes d’écriture**
- fonctionner pour les valeurs :

```

1 ≤ n < 4000

```
