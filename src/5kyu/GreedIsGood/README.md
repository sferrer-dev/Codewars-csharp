# 🎲 Greed is Good

![Codewars](https://img.shields.io/badge/Codewars-5kyu-yellow)
![Language](https://img.shields.io/badge/Language-C%23-blue)
![Framework](https://img.shields.io/badge/.NET-8.0-purple)

## 📘 Description

**Greed** est un jeu de dés joué avec **cinq dés à six faces**.

Votre mission est d'écrire une fonction qui **calcule le score d'un lancer de dés** en respectant les règles du jeu.

La fonction reçoit **un tableau contenant les valeurs des cinq dés** et doit retourner **le score correspondant**.

🔗 **Kata Codewars** - [Greed is Good](https://www.codewars.com/kata/5270d0d18625160ada0000e4)

<p align="center">• • •</p>

## ⚙️ Règles de score

Le score dépend des combinaisons obtenues :

| Combinaison | Score |
|--------------|------|
| Trois `1` | 1000 points |
| Trois `6` | 600 points |
| Trois `5` | 500 points |
| Trois `4` | 400 points |
| Trois `3` | 300 points |
| Trois `2` | 200 points |
| Un `1` | 100 points |
| Un `5` | 50 points |

Chaque dé **ne peut être compté qu'une seule fois** dans le calcul du score.

Par exemple :

- un `5` utilisé dans une combinaison de **trois 5** ne peut **pas être compté à nouveau comme un 5 isolé**.

<p align="center">• • •</p>

## 💡 Principe

Le traitement consiste à :

1. compter **le nombre d'occurrences de chaque valeur de dé**
2. appliquer les règles de score
3. additionner les points correspondants

Conceptuellement :

```

compter chaque valeur de dé
si 3 occurrences → appliquer le score du triplet
si valeur restante 1 ou 5 → ajouter les points unitaires

```

<p align="center">• • •</p>

## 🔎 Exemples

| Lancer | Score | Explication |
|------|------|-------------|
| `[5,1,3,4,1]` | `250` | 50 (pour le 5) + 2 × 100 (pour les 1) |
| `[1,1,1,3,1]` | `1100` | 1000 (pour trois 1) + 100 (pour le 1 restant) |
| `[2,4,4,5,4]` | `450` | 400 (pour trois 4) + 50 (pour le 5) |

<p align="center">• • •</p>

## ⚠️ Contraintes

- La fonction reçoit **exactement cinq dés**
- Les valeurs possibles sont **1 à 6**
- Le tableau d'entrée **ne doit pas être modifié**

<p align="center">• • •</p>

## 🧪 Tests

Les tests unitaires associés sont disponibles dans le projet :

- 📁 [Projet de tests NUnit](../../../tests/5kyu/GreedIsGood.Tests/)

Les tests couvrent notamment :

- les **combinaisons de triplets**
- les **scores unitaires pour 1 et 5**
- différentes **configurations de lancers**
- le respect de la contrainte **ne pas modifier le tableau d'entrée**

<p align="center">• • •</p>

## 🧾 Résumé

La fonction doit :

- recevoir **un tableau contenant cinq dés**
- calculer **le score du lancer selon les règles du jeu Greed**
- respecter les **combinaisons et scores définis**
- retourner **le score total**

Exemple :

```

[5,1,3,4,1]
→
250

```
