# ⏰ L1 – Set Alarm

![Codewars](https://img.shields.io/badge/Codewars-8kyu-red)
![Language](https://img.shields.io/badge/Language-C%23-blue)
![Framework](https://img.shields.io/badge/.NET-8.0-purple)

## 📘 Description

Écrire une fonction `setAlarm` qui détermine s'il faut **activer une alarme** en fonction de deux paramètres booléens.

### Paramètres
- **`employed`** : indique si vous êtes employé (`true`)
- **`vacation`** : indique si vous êtes en vacances (`true`)

### Comportement attendu
La fonction doit retourner :
- `true` → si vous êtes **employé** **et** **pas en vacances**
- `false` → dans tous les autres cas

L'alarme doit être activée uniquement lorsque vous devez **aller travailler**.

🔗 **Kata Codewars** - [L1: Set Alarm](https://www.codewars.com/kata/568dcc3c7f12767a62000038)

<p align="center">• • •</p>

## ⚙️ Règle logique

```csharp
employed == true && vacation == false
```

ou de manière simplifiée :

```csharp
employed && !vacation
```

## Exemples

| employed | vacation | résultat |
|---------|----------|----------|
| true | true | false |
| true | false | true |
| false | true | false |
| false | false | false |

<p align="center">• • •</p>


## 🧪 Tests

Les tests unitaires associés sont disponibles dans le projet :  
- 📁 [Projet de tests NUnits](../../../tests/8kyu/L1SetAlarm.Tests/)


<p align="center">• • •</p>

## 🧾 Résumé

La fonction renvoie **true uniquement dans un seul cas** :

- lorsque la personne **travaille** et **n'est pas en vacances**.

Dans tous les autres cas, elle renvoie **false**.
