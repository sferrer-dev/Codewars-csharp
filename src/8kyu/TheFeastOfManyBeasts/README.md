# 🍽️ The Feast of Many Beasts

![Codewars](https://img.shields.io/badge/Codewars-8kyu-red)
![Language](https://img.shields.io/badge/Language-C%23-blue)
![Framework](https://img.shields.io/badge/.NET-8.0-purple)

## 📘 Description

Tous les animaux se régalent lors du **Festin des nombreuses bêtes** !  
Chaque animal doit apporter un plat pour participer.

Cependant, **une seule règle** s'applique :

> Le nom du plat doit **commencer et se terminer par les mêmes lettres que le nom de l'animal**.

Si cette règle est respectée, l'animal est **autorisé à participer au festin**.

🔗 **Kata Codewars** - [The Feast of Many Beasts](https://www.codewars.com/kata/5aa736a455f906981800360d)

<p align="center">• • •</p>

## ⚙️ Règles

La fonction doit respecter les règles suivantes :

- Recevoir deux chaînes de caractères :
  - `beast` → le nom de l'animal
  - `dish` → le nom du plat
- Comparer :
  - la **première lettre** du nom de l'animal et du plat
  - la **dernière lettre** du nom de l'animal et du plat
- Retourner :

  - `true` → si les deux lettres correspondent
  - `false` → sinon

<p align="center">• • •</p>

## 📏 Contraintes

Les paramètres respectent toujours les conditions suivantes :

- `beast` et `dish` sont **des chaînes en minuscules**
- Elles contiennent **au moins deux caractères**
- Elles peuvent contenir :
  - des **espaces**
  - des **tirets**
- Elles **ne commencent ni ne se terminent** par un espace ou un tiret
- Elles **ne contiennent pas de chiffres**

<p align="center">• • •</p>

## 💡 Principe

Le traitement consiste à **comparer les premières et dernières lettres des deux chaînes**.

Conceptuellement :

```

beast[0] == dish[0] && beast[last] == dish[last]

```

Si les deux conditions sont vraies, l'animal peut **participer au festin**.

<p align="center">• • •</p>

## 🔎 Exemples

| Animal | Plat | Explication | Résultat |
|------|------|-------------|----------|
| `"great blue heron"` | `"garlic naan"` | g = g et n = n | `true` |
| `"chickadee"` | `"chocolate cake"` | c = c et e = e | `true` |
| `"owl"` | `"chocolate éclair"` | o ≠ c | `false` |

<p align="center">• • •</p>

## 🧪 Tests

Les tests unitaires associés sont disponibles dans le projet :

- 📁 [Projet de tests NUnit](../../../tests/8kyu/TheFeastOfManyBeasts.Tests/)

Les tests couvrent notamment :

- la **correspondance correcte des premières lettres**
- la **correspondance correcte des dernières lettres**
- des **combinaisons valides et invalides**
- plusieurs **tests automatiques avec différents noms d’animaux et de plats**

<p align="center">• • •</p>

## 🧾 Résumé

La fonction doit :

- recevoir **le nom d’un animal** et **le nom d’un plat**
- comparer **la première et la dernière lettre de chaque chaîne**
- retourner :

```

true  → si les lettres correspondent
false → sinon

```

