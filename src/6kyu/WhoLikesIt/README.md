# 👍 Who likes it?

![Codewars](https://img.shields.io/badge/Codewars-6kyu-yellow)
![Language](https://img.shields.io/badge/Language-C%23-blue)
![Framework](https://img.shields.io/badge/.NET-8.0-purple)

## 📘 Description

Vous connaissez probablement le système de **"likes"** utilisé sur Facebook ou d'autres plateformes.

Les utilisateurs peuvent **aimer (like)** des publications, des photos ou d'autres contenus.  
L'objectif de ce kata est de **générer le texte affiché indiquant quelles personnes aiment un élément**.

La fonction reçoit **un tableau contenant les noms des personnes qui aiment l'élément** et doit retourner **le texte correspondant** selon certaines règles.

🔗 **Kata Codewars** - [Who likes it?](https://www.codewars.com/kata/5266876b8f4bf2da9b000362)

<p align="center">• • •</p>

## ⚙️ Règles

La fonction doit respecter les règles suivantes :

- Recevoir **un tableau de chaînes contenant les noms des personnes**
- Générer **le texte affiché en fonction du nombre de personnes**
- Adapter **la grammaire et le nombre de noms affichés**

Les cas possibles sont :

| Nombre de personnes | Texte retourné |
|---------------------|---------------|
| 0 | `"no one likes this"` |
| 1 | `"Peter likes this"` |
| 2 | `"Jacob and Alex like this"` |
| 3 | `"Max, John and Mark like this"` |
| 4 ou plus | `"Alex, Jacob and 2 others like this"` |

Pour **4 personnes ou plus**, seuls les **deux premiers noms** sont affichés, suivis de :

```

and X others like this

```

où `X` représente **le nombre de personnes restantes**.

<p align="center">• • •</p>

## 💡 Principe

Le traitement consiste à **adapter le texte en fonction du nombre d'éléments dans le tableau**.

Conceptuellement :

```

si aucun nom
retourner "no one likes this"
si un nom
afficher "Nom likes this"
si deux noms
afficher "Nom1 and Nom2 like this"
si trois noms
afficher "Nom1, Nom2 and Nom3 like this"
si plus de trois noms
afficher "Nom1, Nom2 and X others like this"

```

<p align="center">• • •</p>

## 🔎 Exemples

| Entrée | Résultat |
|------|----------|
| `[]` | `"no one likes this"` |
| `["Peter"]` | `"Peter likes this"` |
| `["Jacob", "Alex"]` | `"Jacob and Alex like this"` |
| `["Max", "John", "Mark"]` | `"Max, John and Mark like this"` |
| `["Alex", "Jacob", "Mark", "Max"]` | `"Alex, Jacob and 2 others like this"` |

<p align="center">• • •</p>

## 🧪 Tests

Les tests unitaires associés sont disponibles dans le projet :

- 📁 [Projet de tests NUnit](../../../tests/6kyu/WhoLikesIt.Tests/)

Les tests couvrent notamment :

- les **différents nombres de personnes**
- la **génération correcte du texte**
- la **gestion des cas avec plusieurs utilisateurs**
- plusieurs **tests automatiques avec différentes listes de noms**

<p align="center">• • •</p>

## 🧾 Résumé

La fonction doit :

- recevoir **une liste de noms**
- adapter **le texte affiché selon le nombre de personnes**
- retourner **la phrase correspondant au système de likes**

Exemples :

```

[] → "no one likes this"
["Peter"] → "Peter likes this"
["Alex","Jacob","Mark","Max"] → "Alex, Jacob and 2 others like this"

```
