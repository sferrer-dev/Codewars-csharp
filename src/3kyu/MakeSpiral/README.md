# 🌀 Make a Spiral

![Codewars](https://img.shields.io/badge/Codewars-3kyu-red)
![Language](https://img.shields.io/badge/Language-C%23-blue)
![Framework](https://img.shields.io/badge/.NET-8.0-purple)

## 📘 Description

Écrire une fonction capable de générer une **spirale carrée de taille `N x N`**.

La spirale doit être construite sous la forme d’un **tableau de tableaux d’entiers**, contenant uniquement des **`1`** et des **`0`**.

La première ligne de la matrice doit être entièrement composée de **`1`**, puis le tracé doit continuer en formant une spirale vers l’intérieur.

🔗 **Kata Codewars** - [Make a spiral](https://www.codewars.com/kata/534e01fbbb17187c7e0000c6)

<p align="center">• • •</p>

## ⚙️ Règles

La fonction doit respecter les contraintes suivantes :

* la matrice retournée est de taille **`N x N`**
* elle contient uniquement des valeurs **`0`** et **`1`**
* la spirale commence en haut à gauche avec une première ligne remplie de **`1`**
* le chemin formé par les **`1`** ne doit **jamais se toucher lui-même**
* la taille minimale fournie par le kata est **`5`**

L’idée générale est de dessiner un “serpent” de `1` qui tourne sur lui-même sans jamais entrer en contact direct avec sa propre trajectoire.

<p align="center">• • •</p>

## 💡 Exemples

### Spirale de taille 5

Représentation visuelle :

```text
00000
....0
000.0
0...0
00000
```

Résultat attendu :

```csharp
[
  [1,1,1,1,1],
  [0,0,0,0,1],
  [1,1,1,0,1],
  [1,0,0,0,1],
  [1,1,1,1,1]
]
```

### Spirale de taille 10

Représentation visuelle :

```text
0000000000
.........0
00000000.0
0......0.0
0.0000.0.0
0.0..0.0.0
0.0....0.0
0.000000.0
0........0
0000000000
```

<p align="center">• • •</p>

## 🧠 Principe algorithmique

Une approche classique consiste à :

1. créer une matrice initialement remplie de `0`
2. parcourir cette matrice en suivant une direction courante :

   * droite
   * bas
   * gauche
   * haut
3. écrire des `1` tant que l’on peut avancer sans :

   * sortir de la grille
   * toucher la spirale déjà tracée
4. tourner lorsque l’avancement n’est plus autorisé
5. répéter jusqu’à ce que la spirale soit complète

Le point délicat du kata réside dans la règle suivante :

> une case contenant `1` ne doit pas créer de contact direct avec une autre portion de la spirale, sauf avec la case précédente du tracé.

Cela impose de contrôler non seulement la case suivante, mais aussi l’environnement autour du mouvement envisagé.

<p align="center">• • •</p>

## 🧪 Tests

Les tests unitaires associés sont disponibles dans le projet :

* 📁 [Projet de tests NUnit](../../../tests/3kyu/MakeSpiral.Tests/)

Les tests vérifient notamment :

* la bonne dimension de la matrice générée
* la conformité du tracé en spirale
* le respect des cas limites pour les petites tailles
* l’absence de contact invalide entre deux segments de la spirale

<p align="center">• • •</p>

## 🧾 Résumé

Ce kata demande de générer une **spirale carrée en binaire** :

* `1` représente le chemin de la spirale
* `0` représente l’espace vide
* la spirale doit tourner proprement vers l’intérieur
* elle ne doit jamais se toucher

C’est un excellent exercice pour travailler :

* la manipulation de tableaux 2D
* la gestion des directions
* les conditions de déplacement
* la logique algorithmique sur grille

## 🏷️ Tags

`Algorithms` `Arrays` `Logic`
