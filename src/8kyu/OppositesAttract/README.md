# 🌸 Opposites Attract

![Codewars](https://img.shields.io/badge/Codewars-8kyu-red)
![Language](https://img.shields.io/badge/Language-C%23-blue)
![Framework](https://img.shields.io/badge/.NET-8.0-purple)

## 📘 Description

Timmy et Sarah pensent être amoureux.  
Mais dans leur région, ils ne peuvent en être certains qu'après avoir **cueilli chacun une fleur**.

Chaque fleur possède un **nombre de pétales**.

La règle est simple :

- si **une fleur possède un nombre pair de pétales**
- et que **l'autre possède un nombre impair**

alors **ils sont amoureux**.

Votre objectif est d'écrire une fonction qui :

- reçoit **le nombre de pétales de chaque fleur**
- retourne `true` **s'ils sont amoureux**
- retourne `false` **dans le cas contraire**

🔗 **Kata Codewars** - [Opposites Attract](https://www.codewars.com/kata/555086d53eac039a2a000083)

<p align="center">• • •</p>

## ⚙️ Règles

La fonction doit respecter les règles suivantes :

- Recevoir **deux entiers positifs**
  - `flower1`
  - `flower2`
- Déterminer si les nombres sont **pair et impair**
- Retourner :

  - `true` → si **l'un est pair et l'autre impair**
  - `false` → dans tous les autres cas

<p align="center">• • •</p>

## 💡 Principe

Un nombre est :

- **pair** si le reste de la division par `2` est `0`
- **impair** si le reste est `1`

En C# :

```

nombre % 2 == 0   // pair
nombre % 2 != 0   // impair

```

Pour ce kata, les deux fleurs doivent avoir une **parité différente**.

Conceptuellement :

```

une fleur paire ET l'autre impaire

```

<p align="center">• • •</p>

## 🔎 Exemples

| Fleur 1 | Fleur 2 | Explication | Résultat |
|--------|--------|-------------|----------|
| 1 | 4 | impair et pair | `true` |
| 2 | 2 | pair et pair | `false` |
| 0 | 1 | pair et impair | `true` |
| 5 | 7 | impair et impair | `false` |

<p align="center">• • •</p>

## 🧪 Tests

Les tests unitaires associés sont disponibles dans le projet :

- 📁 [Projet de tests NUnit](../../../tests/8kyu/OppositesAttract.Tests/)

Les tests couvrent notamment :

- la **détection correcte des nombres pairs et impairs**
- des **combinaisons pair/impair**
- des cas **pair/pair et impair/impair**
- plusieurs **tests automatiques avec différentes valeurs**

<p align="center">• • •</p>

## 🧾 Résumé

La fonction doit :

- recevoir **le nombre de pétales de deux fleurs**
- vérifier si **les deux nombres ont une parité différente**
- retourner :

```

true  → si une fleur est paire et l'autre impaire
false → sinon

```
