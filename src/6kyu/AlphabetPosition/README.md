# 🔤 Replace With Alphabet Position

![Codewars](https://img.shields.io/badge/Codewars-6kyu-red)
![Language](https://img.shields.io/badge/Language-C%23-blue)
![Framework](https://img.shields.io/badge/.NET-8.0-purple)

## 📘 Description

Dans ce kata, l'objectif est de **remplacer chaque lettre d'une chaîne de caractères par sa position dans l'alphabet**.

Chaque lettre correspond à une position :

```

a = 1
b = 2
c = 3
...
z = 26

```

Tous les caractères qui **ne sont pas des lettres** doivent être **ignorés** et **ne doivent pas apparaître dans le résultat**.

🔗 **Kata Codewars**  
https://www.codewars.com/kata/546f922b54af40e1e90001da

<p align="center">• • •</p>

## ⚙️ Règles

La fonction doit :

1. Parcourir chaque caractère du texte fourni.
2. Vérifier si ce caractère est une **lettre de l'alphabet**.
3. Convertir cette lettre en **position dans l'alphabet**.
4. Ignorer tous les caractères qui **ne sont pas des lettres** :
   - espaces
   - ponctuation
   - chiffres
   - symboles
5. Retourner une **chaîne de nombres séparés par des espaces**.

<p align="center">• • •</p>

## 🧠 Principe

Pour obtenir la position d'une lettre dans l'alphabet, on peut utiliser son **code ASCII**.

En C# :

```

position = caractère - 'a' + 1

```

Pour simplifier le traitement :

1. Convertir la chaîne en **minuscules**
2. Filtrer uniquement les caractères **alphabétiques**
3. Calculer la position de chaque lettre
4. Construire la chaîne de sortie séparée par des espaces

<p align="center">• • •</p>

## 🧩 Exemple

### Entrée

```

"The sunset sets at twelve o' clock."

```

### Sortie

```

20 8 5 19 21 14 19 5 20 19 5 20 19 1 20 20 23 5 12 22 5 15 3 12 15 3 11

```

### Explication

```

T -> 20
h -> 8
e -> 5

```

Les caractères suivants sont **ignorés** :

```

espace
'
.

```

<p align="center">• • •</p>

## 🔎 Exemple de transformation

| Lettre | Position |
|------|------|
| a | 1 |
| b | 2 |
| c | 3 |
| d | 4 |
| e | 5 |
| ... | ... |
| z | 26 |

<p align="center">• • •</p>

## 🧪 Tests

Les tests unitaires sont disponibles dans le projet :

📁 **Projet NUnit**

```

../../../tests/6kyu/AlphabetPosition.Tests/

````

Les tests doivent vérifier notamment :

- une phrase simple
- une phrase avec ponctuation
- une phrase contenant des majuscules
- une chaîne vide
- une chaîne ne contenant aucun caractère alphabétique

<p align="center">• • •</p>

## 🧩 Exemple d’utilisation

```csharp
AlphabetPosition.Replace("abc");
````

Résultat :

```
1 2 3
```

<p align="center">• • •</p>

## 🏷️ Catégories

* Strings
* Fundamentals

<p align="center">• • •</p>

## 🧾 Résumé

Ce kata consiste à transformer une chaîne de caractères en une **suite de positions alphabétiques**.

Les règles principales sont :

* convertir chaque lettre en position `1..26`
* ignorer tous les caractères non alphabétiques
* retourner les valeurs séparées par des espaces
