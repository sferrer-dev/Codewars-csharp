# 🧹 Strip Comments

![Codewars](https://img.shields.io/badge/Codewars-4kyu-purple)
![Language](https://img.shields.io/badge/Language-C%23-blue)
![Framework](https://img.shields.io/badge/.NET-8.0-purple)

## 📘 Description

Écrire une fonction qui **supprime les commentaires d’un texte**.

La fonction reçoit :

- une **chaîne de caractères contenant plusieurs lignes**
- un **ensemble de marqueurs de commentaires**

Tout le texte **situé après un marqueur de commentaire sur une ligne doit être supprimé**.

De plus, **les espaces en fin de ligne doivent également être supprimés**.

🔗 **Kata Codewars** - [Strip Comments](https://www.codewars.com/kata/51c8e37cee245da6b40000bd)

<p align="center">• • •</p>

## ⚙️ Règles

La fonction doit respecter les règles suivantes :

- Recevoir :
  - `text` → une chaîne contenant **plusieurs lignes**
  - `commentMarkers` → une **liste de marqueurs de commentaires**
- Pour chaque ligne :
  - supprimer **tout le texte situé après un marqueur**
  - supprimer **les espaces à la fin de la ligne**
- Conserver **le reste du texte intact**
- Retourner **la nouvelle chaîne nettoyée**

<p align="center">• • •</p>

## 💡 Principe

Le traitement consiste à :

1. **Découper le texte ligne par ligne**
2. Rechercher la présence d’un **marqueur de commentaire**
3. Conserver uniquement **la partie avant le marqueur**
4. Supprimer **les espaces en fin de ligne**

Conceptuellement :

```

pour chaque ligne
trouver le premier marqueur de commentaire
supprimer le texte après ce marqueur
supprimer les espaces en fin de ligne

```

<p align="center">• • •</p>

## 🔎 Exemple

Entrée :

```

apples, pears # and bananas
grapes
bananas !apples

```

Avec les marqueurs :

```

["#", "!"]

```

Résultat attendu :

```

apples, pears
grapes
bananas

```

Explication :

- `#` supprime le texte **après "apples, pears"**
- `!` supprime le texte **après "bananas"**
- les **espaces en fin de ligne sont supprimés**

<p align="center">• • •</p>

## 🧪 Tests

Les tests unitaires associés sont disponibles dans le projet :

- 📁 [Projet de tests NUnit](../../../tests/4kyu/StripComments.Tests/)

Les tests couvrent notamment :

- la **suppression correcte des commentaires**
- la **gestion de plusieurs marqueurs**
- la **suppression des espaces en fin de ligne**
- des **textes contenant plusieurs lignes**
- plusieurs **tests automatiques**

<p align="center">• • •</p>

## 🧾 Résumé

La fonction doit :

- recevoir **un texte multi-ligne**
- recevoir **une liste de marqueurs de commentaires**
- supprimer **tout le texte situé après un marqueur**
- supprimer **les espaces en fin de ligne**
- retourner **le texte nettoyé**

Exemple :

```

apples, pears # and bananas
grapes
bananas !apples

```

Résultat :

```

apples, pears
grapes
bananas

```
