# 🔢 Filter the number

![Codewars](https://img.shields.io/badge/Codewars-7kyu-orange)
![Language](https://img.shields.io/badge/Language-C%23-blue)
![Framework](https://img.shields.io/badge/.NET-8.0-purple)

## 📘 Description

Oh non ! Un nombre a été **mélangé avec du texte**.

Votre objectif est de **retrouver le nombre caché dans la chaîne de caractères** et de le **reconstituer dans son état original**.

La chaîne fournie en entrée contient **un mélange de lettres et de chiffres**.  
La fonction doit **extraire tous les chiffres présents dans la chaîne** et les **assembler dans l'ordre d'apparition** pour former le nombre final.

🔗 **Kata Codewars** - [Filter the number](https://www.codewars.com/kata/55b051fac50a3292a9000025)

<p align="center">• • •</p>

## ⚙️ Règles

La fonction doit respecter les règles suivantes :

- Recevoir **une chaîne contenant des lettres et des chiffres**
- Extraire **tous les caractères numériques**
- Conserver **l'ordre d'apparition des chiffres**
- Reconstituer le **nombre correspondant**
- Retourner **ce nombre**

<p align="center">• • •</p>

## 💡 Principe

Le traitement consiste à :

1. Parcourir la chaîne de caractères
2. Conserver uniquement les **chiffres**
3. Construire le **nombre final à partir de ces chiffres**

Conceptuellement :

```

résultat = concaténation de tous les chiffres trouvés dans la chaîne

```

Puis conversion en nombre.

<p align="center">• • •</p>

## 🔎 Exemples

| Chaîne originale | Chiffres extraits | Résultat |
|------------------|------------------|----------|
| `"a1b2c3"` | `1 2 3` | `123` |
| `"abc123"` | `1 2 3` | `123` |
| `"a1b2c3d4"` | `1 2 3 4` | `1234` |
| `"123"` | `1 2 3` | `123` |

<p align="center">• • •</p>

## 🧪 Tests

Les tests unitaires associés sont disponibles dans le projet :

- 📁 [Projet de tests NUnit](../../../tests/7kyu/FilterTheNumber.Tests/)

Les tests couvrent notamment :

- l'**extraction correcte des chiffres**
- la **conservation de l'ordre des chiffres**
- des chaînes contenant **différentes combinaisons de lettres et de nombres**
- plusieurs **tests automatiques avec différentes chaînes**

<p align="center">• • •</p>

## 🧾 Résumé

La fonction doit :

- recevoir **une chaîne contenant lettres et chiffres**
- **extraire tous les chiffres**
- **reconstruire le nombre dans l'ordre d'apparition**
- retourner **le nombre obtenu**
