# 🧭 Directions Reduction

![Codewars](https://img.shields.io/badge/Codewars-5kyu-red)
![Language](https://img.shields.io/badge/Language-C%23-blue)
![Framework](https://img.shields.io/badge/.NET-8.0-purple)

## 📘 Description

Il était une fois, dans l’Ouest sauvage et montagneux, un homme devait traverser un désert dangereux en suivant une série d’instructions.

Les directions possibles sont :

```

NORTH
SOUTH
EAST
WEST

```

Certaines directions sont **opposées** :

```

NORTH ↔ SOUTH
EAST  ↔ WEST

```

Se déplacer dans une direction puis revenir immédiatement dans la direction opposée est **inutile** et fait perdre de l'énergie.

Dans cet environnement hostile, il est essentiel d'optimiser le trajet afin de **supprimer les déplacements inutiles**.

🔗 **Kata Codewars**  
https://www.codewars.com/kata/550f22f4d758534c1100025a

<p align="center">• • •</p>

## ⚙️ Objectif

Écrire une fonction :

```

dirReduc

```

qui :

- prend en entrée une **liste de directions**
- supprime toutes les **paires de directions opposées adjacentes**
- retourne la **liste simplifiée**

La simplification doit continuer **tant que de nouvelles réductions sont possibles**.

<p align="center">• • •</p>

## 🧠 Principe

Deux directions adjacentes s'annulent si elles sont opposées :

| Direction | Opposée |
|---|---|
| NORTH | SOUTH |
| SOUTH | NORTH |
| EAST | WEST |
| WEST | EAST |

Si deux directions opposées se suivent immédiatement, elles peuvent être supprimées.

Exemple :

```

NORTH + SOUTH = annulation
EAST + WEST   = annulation

```

Cependant, certaines directions peuvent devenir opposées **après une première simplification**.

L’algorithme doit donc continuer la réduction jusqu’à ce qu’aucune simplification supplémentaire ne soit possible.

<p align="center">• • •</p>

## 🧩 Exemple 1

### Entrée

```

["NORTH", "SOUTH", "SOUTH", "EAST", "WEST", "NORTH", "WEST"]

```

### Étapes

```

NORTH + SOUTH -> supprimé

```

reste :

```

["SOUTH", "EAST", "WEST", "NORTH", "WEST"]

```
```

EAST + WEST -> supprimé

```

reste :

```

["SOUTH", "NORTH", "WEST"]

```
```

SOUTH + NORTH -> supprimé

```

reste :

```

["WEST"]

```

### Résultat

```

["WEST"]

```

<p align="center">• • •</p>

## 🧩 Exemple 2

### Entrée

```

["NORTH", "SOUTH", "EAST", "WEST"]

```

### Simplification

```

NORTH + SOUTH -> supprimé
EAST + WEST   -> supprimé

```

### Résultat

```

[]

```

Le chemin est complètement annulé.

<p align="center">• • •</p>

## 🧩 Exemple 3

### Entrée

```

["NORTH", "EAST", "WEST", "SOUTH", "WEST", "WEST"]

```

Étapes :

```

EAST + WEST -> supprimé

```

reste :

```

["NORTH", "SOUTH", "WEST", "WEST"]

```
```

NORTH + SOUTH -> supprimé

```

### Résultat

```

["WEST", "WEST"]

```

<p align="center">• • •</p>

## ❗ Cas non réductible

Certaines séquences ne peuvent pas être simplifiées.

### Exemple

```

["NORTH", "WEST", "SOUTH", "EAST"]

```

Aucune paire opposée adjacente n'existe.

### Résultat

```

["NORTH", "WEST", "SOUTH", "EAST"]

````

Le chemin reste inchangé.

<p align="center">• • •</p>

## 🧩 Exemple d’utilisation

```csharp
DirReduction.DirReduc(new[] { "NORTH", "SOUTH", "EAST", "WEST" });
````

Résultat :

```
[]
```

<p align="center">• • •</p>

## 🧪 Tests

Les tests unitaires sont disponibles dans le projet :

- 📁 [Projet de tests NUnit](../../../tests/5kyu/DirectionsReduction.Tests/)

Les tests doivent vérifier notamment :

* la suppression correcte des directions opposées
* plusieurs niveaux de simplification
* un chemin entièrement annulé
* un chemin non réductible
* la conservation de l'ordre des directions restantes

<p align="center">• • •</p>

## 🧠 Concepts abordés

Ce kata permet de travailler plusieurs notions algorithmiques importantes :

* manipulation de tableaux
* logique de réduction
* structures de données (pile / stack)
* simplification progressive d'une séquence

<p align="center">• • •</p>

## 🏷️ Catégories

* Fundamentals

<p align="center">• • •</p>

## 🧾 Résumé

Ce kata consiste à **simplifier un chemin composé de directions cardinales**.

La fonction doit :

* détecter les directions opposées adjacentes
* supprimer les déplacements inutiles
* répéter la réduction jusqu’à stabilisation

Le résultat final est **le chemin minimal équivalent**.

