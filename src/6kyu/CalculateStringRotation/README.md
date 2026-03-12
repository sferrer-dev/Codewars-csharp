# 🔄 Calculate String Rotation

![Codewars](https://img.shields.io/badge/Codewars-6kyu-yellow)
![Language](https://img.shields.io/badge/Language-C%23-blue)
![Framework](https://img.shields.io/badge/.NET-8.0-purple)

## 📘 Description

Écrire une fonction qui reçoit **deux chaînes de caractères** et retourne **le nombre de positions (`n`) nécessaires pour faire tourner la première chaîne afin d’obtenir la seconde**.

Une **rotation** consiste à déplacer les caractères du début de la chaîne vers la fin.

La comparaison est **sensible à la casse** (*case sensitive*).

Si la seconde chaîne **n'est pas une rotation valide de la première**, la fonction doit retourner **`-1`**.

🔗 **Kata Codewars** - [Calculate String Rotation](https://www.codewars.com/kata/5596f6e9529e9ab6fb000014)

<p align="center">• • •</p>

## ⚙️ Règles

La fonction doit respecter les règles suivantes :

- Recevoir **deux chaînes de caractères**
  - `first` → chaîne d'origine
  - `second` → chaîne cible
- Déterminer **combien de caractères il faut déplacer vers l'avant**
- La comparaison est **sensible à la casse**
- Si `second` n'est **pas une rotation valide** de `first`, retourner **`-1`**

<p align="center">• • •</p>

## 💡 Principe

Une rotation consiste à **déplacer les premiers caractères de la chaîne vers la fin**.

Conceptuellement :

```

rotation = déplacer les caractères du début vers la fin

```

Exemple :

```

fatigue → atiguef → tiguefa

```

Dans cet exemple :

```

"fatigue" → "tiguefa"

```

La chaîne a été **rotée de 5 positions**, donc la fonction doit retourner :

```

5

```

<p align="center">• • •</p>

## 🔎 Exemples

| Chaîne 1 | Chaîne 2 | Rotation | Résultat |
|----------|----------|----------|----------|
| `"coffee"` | `"eecoff"` | rotation de 2 | `2` |
| `"eecoff"` | `"coffee"` | rotation de 4 | `4` |
| `"moose"` | `"Moose"` | casse différente | `-1` |
| `"isn't"` | `"'tisn"` | rotation de 2 | `2` |
| `"Esham"` | `"Esham"` | aucune rotation | `0` |
| `"dog"` | `"god"` | pas une rotation valide | `-1` |

<p align="center">• • •</p>

## 🧪 Tests

Les tests unitaires associés sont disponibles dans le projet :

- 📁 [Projet de tests NUnit](../../../tests/6kyu/CalculateStringRotation.Tests/)

Les tests couvrent notamment :

- les **rotations valides**
- les **rotations inverses**
- les **chaînes identiques**
- la **sensibilité à la casse**
- les cas où **la rotation n'est pas possible**

<p align="center">• • •</p>

## 🧾 Résumé

La fonction doit :

- recevoir **deux chaînes de caractères**
- déterminer **le nombre de rotations nécessaires pour transformer la première en seconde**
- retourner :

```

n   → nombre de rotations nécessaires
-1  → si la seconde chaîne n'est pas une rotation valide

```
