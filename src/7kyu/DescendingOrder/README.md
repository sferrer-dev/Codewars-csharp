# 🔢 Descending Order

![Codewars](https://img.shields.io/badge/Codewars-7kyu-red)
![Language](https://img.shields.io/badge/Language-C%23-blue)
![Framework](https://img.shields.io/badge/.NET-8.0-purple)

## 📘 Description

Écrire une fonction qui prend **un entier non négatif** en paramètre et retourne un **nouvel entier dont les chiffres sont triés dans l’ordre décroissant**.

L'objectif est de **réorganiser les chiffres du nombre pour produire le plus grand nombre possible**.

🔗 **Kata Codewars**  
[Descending Order](https://www.codewars.com/kata/5467e4d82edf8bbf40000155)

<p align="center">• • •</p>

## ⚙️ Règles

La fonction doit respecter les règles suivantes :

- L’entrée est un **entier non négatif**
- Les **chiffres du nombre doivent être réorganisés**
- Le résultat doit être **le plus grand nombre possible** formé avec ces chiffres
- Le résultat doit être retourné sous forme **d’entier**

<p align="center">• • •</p>

## 💡 Principe

L’algorithme peut être résumé en plusieurs étapes :

1. Convertir le nombre en **chaîne de caractères**
2. Extraire les **chiffres individuellement**
3. Trier les chiffres **du plus grand au plus petit**
4. Recomposer le nombre à partir des chiffres triés

<p align="center">• • •</p>

## 🔎 Exemples

| Entrée | Résultat |
|------|------|
| `42145` | `54421` |
| `145263` | `654321` |
| `123456789` | `987654321` |
| `0` | `0` |

<p align="center">• • •</p>

## 🧪 Tests

Les tests unitaires associés sont disponibles dans le projet :

- 📁 **Projet de tests NUnit**  
  `../../../tests/7kyu/DescendingOrder.Tests/`

Les tests vérifient notamment :

- le tri correct des chiffres
- le comportement avec différents nombres
- les cas simples et les cas plus longs
- les valeurs limites

<p align="center">• • •</p>

## 🧾 Résumé

La fonction doit :

- recevoir **un entier non négatif**
- **réorganiser ses chiffres en ordre décroissant**
- retourner **le plus grand nombre possible** formé avec ces chiffres.
