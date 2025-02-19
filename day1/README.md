# Day 1 - Roulette Game

## 📝 Variables in C#
A **variable** is a space in memory where we store a value.
Syntax:
typeDate NameVariable = value;
ex: int age = 20;

## 📝 Data types in C#

| Data Type  | Description                          | Example |
|------------|--------------------------------------|---------|
| `int`      | Whole numbers                       | `int x = 10;` |
| `float`    | Decimal numbers (single precision)  | `float pi = 3.14f;` |
| `double`   | Decimal numbers (high precision)    | `double g = 9.81;` |
| `decimal`  | Decimal numbers (financial precision) | `decimal price = 19.99m;` |
| `bool`     | True/False values                   | `bool isActive = true;` |
| `char`     | Single character                    | `char letter = 'A';` |
| `string`   | Sequence of characters              | `string name = "Andrew";` |

## 📝 Control structures (Conditions)
The conditions allow the program to make decisions based on certain rules

### 📌 1. If / Else
```csharp
int age = 18;

if (age >= 18)
{
  Console.WriteLine("You can drive!:D");
}
else
{
  Console.WriteLine("You are not allowed to drive. :(");
}
```

### 📌 2. Else If (multiple conditions)
```csharp
int temperature = 30;

if (temperature > 30)
{
  Console.WriteLine("It's very hot!");
}
else if (temperature > 10)
{
  Console.WriteLine("It's a pleasent temperature.");
}
else
{
  Console.WriteLine("It's cold.");
}
```
The program checks each condition in order.

### 📌 3. Ternary Operator
```csharp
int age = 20;
string message = (age > 18) ? "Adult" : "Minor";
Console.WriteLine(message);
```

### 📌 4. Switch (for multiple values)
```csharp
int day = 3;
switch(day)
{
  case 1:
    Console.WriteLine("Monday");
    break;
  case 2:
    Console.WriteLine("Tuesday");
    break;
  case 3:
    Console.WriteLine("Wednesday");
    break;
  default:
    Console.WriteLine("Other");
    break;
}
```

## 📝 Operators in C#
Operators are used to perform calculations and comparisons

### 📌 1. Arithmetic Operators
| Operators  | Description     | Example |
|------------|-----------------|---------|
| `+`        | Addition        | `x + y` |
| `-`        | Substraction    | `x - y` |
| `*`        | Multiplication  | `x * y` |
| `/`        | Division        | `x / y` |
| `%`        | Modulo          | `x % y` |

### 📌 2. Comparison Operators
| Operators  | Description               | Example |
|------------|---------------------------|---------|
| `==`       | Equal to                  | `x == y` |
| `!=`       | Not equal to              | `x != y` |
| `>`        | Greater than              | `x > y`  |
| `<`        | Less than                 | `x < y`  |
| `>=`       | Greater than or equal to  | `x >= y` |
| `<=`       | Less than or equal to     | `x >= y` |

### 📌 3. Logical Operators
| Operators  | Description               | Example |
|------------|---------------------------|---------|
| `&&`       | AND                 | `x > 5 && X < 10` |
| <code>&#124;&#124;</code>        | OR             | `x > 5` <code>&#124;&#124;</code>  `X < 10` |
| `!`        | NOT             | `!(x > 5)`  |

## 📝 Operators Precedence in C#
In C#, operator precedence determines the order in which expressions are evaluated. Operators with higher precedence are evaluated first, unless parentheses () are used to override the order.
| **Precedence Level** | **Operator**                        | **Description**                               | **Associativity**  |
|----------------------|------------------------------------|-----------------------------------------------|-------------------|
| **1 (Highest)**      | `()`                                | Parentheses (Grouping)                        | Left to Right    |
|                      | `x.y`, `f(x)`                      | Member access, function call                  | Left to Right    |
| **2**               | `++`, `--`                         | Postfix increment/decrement                   | Left to Right    |
| **3**               | `++`, `--`, `+`, `-`, `!`, `~`      | Prefix increment, decrement, unary plus/minus, logical NOT, bitwise NOT | Right to Left |
| **4**               | `*`, `/`, `%`                      | Multiplication, division, modulus             | Left to Right    |
| **5**               | `+`, `-`                           | Addition, subtraction                         | Left to Right    |
| **6**               | `<<`, `>>`                         | Bitwise shift left/right                      | Left to Right    |
| **7**               | `<`, `<=`, `>`, `>=`               | Relational (less than, greater than, etc.)    | Left to Right    |
| **8**               | `==`, `!=`                         | Equality and inequality                       | Left to Right    |
| **9**               | `&`                                | Bitwise AND                                   | Left to Right    |
| **10**              | `^`                                | Bitwise XOR                                   | Left to Right    |
| **11**              | <code>&#124;</code>                 | Bitwise OR                                    | Left to Right    |
| **12**              | `&&`                               | Logical AND                                   | Left to Right    |
| **13**              | <code>&#124;&#124;</code>           | Logical OR                                    | Left to Right    |
| **14**              | `?:`                               | Ternary conditional                           | Right to Left    |
| **15 (Lowest)**     | `=`, `+=`, `-=`, `*=`, `/=`, `%=`  | Assignment operators                          | Right to Left    |
|                      | `&=`, `|=`, `^=`, `<<=`, `>>=`     | Compound assignment                           | Right to Left    |

# 🎰 Day 1 - Roulette Game (C++)
This is my first project in the **365 Days of Code** challenge, where I am practicing game development and programming concepts daily.

## 🔹 About the Game
This is a simple **roulette simulation** written in **C++**. The game allows the player to place a bet on:
- **Red or Black**
- **Even or Odd**
- **A specific number (0-36)**

The program then generates a **random winning number and color**, and determines if the player's bet was correct.

## 🔹 How It Works
1. The game randomly picks a **winning number (0-36)**.
2. The corresponding **color** is assigned:
   - **0 → Green**
   - **Odd numbers → Red**
   - **Even numbers → Black**
3. The player places a bet.
4. The game checks if the bet **matches the winning number, color, or type (even/odd)**.
5. The result is displayed: `"You won!"` or `"You've lost. Better luck next time!"`.

## 🔹 How to Run the Program
### **1. Compile the C++ Code**
Run the following command in the terminal:
```sh
g++ roulette.cpp -o roulette
