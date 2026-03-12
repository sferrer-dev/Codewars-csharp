# 🎓 How good are you really?

![Codewars](https://img.shields.io/badge/Codewars-8kyu-red)
![Language](https://img.shields.io/badge/Language-C%23-blue)
![Framework](https://img.shields.io/badge/.NET-8.0-purple)

## 📘 Description

Un test a eu lieu dans votre classe et vous l'avez **réussi**. Félicitations !

Mais vous êtes une personne ambitieuse et vous souhaitez savoir si **votre score est supérieur à la moyenne de votre classe**.

On vous fournit un **tableau contenant les notes de vos camarades**.  
Votre objectif est de :

1. **Calculer la moyenne des notes**
2. **Comparer votre score avec cette moyenne**

La fonction doit retourner :

- `true` → si **votre score est supérieur à la moyenne**
- `false` → sinon

🔗 **Kata Codewars** - [How good are you really?](https://www.codewars.com/kata/5601409514fc93442500010b)

<p align="center">• • •</p>

## ⚙️ Règles

La fonction doit respecter les règles suivantes :

- Un tableau contenant **les notes de vos camarades**
- Une valeur représentant **votre propre score**
- Votre score **n'est pas inclus dans le tableau**
- Calculer la **moyenne des notes de la classe**
- Comparer **votre score à cette moyenne**

Résultat attendu :

- `true` si votre score est **strictement supérieur à la moyenne**
- `false` dans tous les autres cas

<p align="center">• • •</p>

## 💡 Principe

Le calcul se fait en deux étapes :

1. Calculer la moyenne des scores de la classe

```

moyenne = somme des notes / nombre d'élèves

```

2. Comparer votre score avec cette moyenne

```

yourScore > moyenne

```

<p align="center">• • •</p>

## 🔎 Exemples

| Notes de la classe | Votre score | Moyenne | Résultat |
|--------------------|-------------|---------|----------|
| `[2, 3]`           | `5`         | `2.5`   | `true`   |
| `[100, 40, 34, 57, 29, 72, 57, 88]` | `75` | `59.625` | `true` |
| `[12, 23, 34, 45]` | `23`        | `28.5`  | `false`  |

<p align="center">• • •</p>

## 🧪 Tests

Les tests unitaires associés sont disponibles dans le projet :

- 📁 [Projet de tests NUnit](../../../tests/8kyu/HowGoodAreYouReally.Tests/)

Les tests couvrent notamment :

- le **calcul correct de la moyenne**
- la **comparaison entre votre score et la moyenne**
- différents **ensembles de scores**
- plusieurs **tests automatiques avec différentes distributions de notes**

<p align="center">• • •</p>

## 🧾 Résumé

La fonction doit :

- recevoir **un tableau de notes de la classe**
- recevoir **votre score**
- **calculer la moyenne des scores**
- retourner :

```

true  → si votre score est supérieur à la moyenne
false → sinon

```
