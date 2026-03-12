# ❌⭕ Tic-Tac-Toe Checker

![Codewars](https://img.shields.io/badge/Codewars-5kyu-yellow)
![Language](https://img.shields.io/badge/Language-C%23-blue)
![Framework](https://img.shields.io/badge/.NET-8.0-purple)

## 📘 Description

Dans un jeu de **Tic-Tac-Toe (morpion)**, il est souvent nécessaire de déterminer **l’état actuel du plateau** afin de savoir si la partie est terminée ou si un joueur a gagné.

Votre objectif est d’écrire une fonction qui **analyse un plateau de jeu 3×3** et détermine l’état de la partie.

Le plateau est représenté par **un tableau 2D** où :

- `0` → case vide
- `1` → joueur **X**
- `2` → joueur **O**

Exemple de plateau :

```

[[0, 0, 1],
[0, 1, 2],
[2, 1, 0]]

```

🔗 **Kata Codewars** - [Tic-Tac-Toe Checker](https://www.codewars.com/kata/525caa5c1bf619d28c000335)

<p align="center">• • •</p>

## ⚙️ Valeurs retournées

La fonction doit retourner :

| Valeur | Signification |
|------|---------------|
| `1` | le joueur **X** a gagné |
| `2` | le joueur **O** a gagné |
| `0` | match nul (*cat's game*) |
| `-1` | la partie n'est pas terminée |

Une partie est **non terminée** si :

- aucun joueur n'a gagné
- et qu'il reste **au moins une case vide**

<p align="center">• • •</p>

## 💡 Principe

Pour déterminer l'état du jeu, il faut vérifier :

1. **les lignes**
2. **les colonnes**
3. **les diagonales**

Si trois symboles identiques sont alignés, alors **le joueur correspondant gagne**.

Conceptuellement :

```

vérifier toutes les lignes
vérifier toutes les colonnes
vérifier les deux diagonales

```

Si aucun gagnant n'est trouvé :

- vérifier s'il reste **des cases vides**
- sinon la partie est **nulle**

<p align="center">• • •</p>

## 🔎 Exemple

Plateau :

```

[[1,1,1],
[0,2,2],
[0,0,0]]

```

Résultat :

```

1

```

Le joueur **X** gagne car la **première ligne est complète**.

---

Autre exemple :

```

[[1,2,1],
[1,2,2],
[2,1,1]]

```

Résultat :

```

0

```

La partie est **terminée sans gagnant**.

<p align="center">• • •</p>

## ⚠️ Hypothèse

Le plateau fourni est **toujours valide** dans le contexte d'une partie de Tic-Tac-Toe.

<p align="center">• • •</p>

## 🧪 Tests

Les tests unitaires associés sont disponibles dans le projet :

- 📁 [Projet de tests NUnit](../../../tests/5kyu/TicTacToe.Tests/)

Les tests couvrent notamment :

- les **victoires par ligne**
- les **victoires par colonne**
- les **victoires par diagonale**
- les **parties non terminées**
- les **matchs nuls**

<p align="center">• • •</p>

## 🧾 Résumé

La fonction doit :

- recevoir **un plateau 3×3**
- analyser **l’état de la partie**
- retourner :

```

1  → X gagne
2  → O gagne
0  → match nul
-1 → partie non terminée

```
