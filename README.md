# C# Course – Language Fundamentals and Hands-On Practice

## Description

This repository is a hands-on learning project designed to **reinforce and regain fluency in C#**, with a strong focus on:

- Language fundamentals
- Compile-time behavior
- Intentional project structure
- Clean, defensible coding practices

The goal is not only to make code work, but to **understand how and why it works**, from the compiler’s perspective and through deliberate design decisions.

This project serves as a **learning log, technical reference, and interview-ready foundation** for C# and .NET development.

---

## Objectives

- Build a solid foundation in the C# language  
- Understand the C# type system and compile-time behavior  
- Use explicit types and type inference (`var`) intentionally  
- Practice fundamentals and algorithms through focused exercises  
- Maintain a clean and scalable project structure  
- Use Git with disciplined, professional workflows  

---

## Learning Scope

The project follows a structured progression from **C# language fundamentals** to **problem-solving and backend-oriented thinking**.

### 1. C# Language Fundamentals (Console-Based)

This phase focuses on mastering the core elements of the C# language using console applications:

- Program structure and entry point (`Program.cs`)
- Variables, literals, and data types
- Type inference vs explicit typing
- String interpolation and escape sequences
- Arithmetic operations and casting
- Control flow and basic logic
- Small, focused exercises to build fluency

All concepts are isolated into runnable modules under the `Fundamentals` folder.

---

### 2. Algorithms and Problem Solving (Interview-Oriented)

This phase introduces classic algorithmic exercises commonly used in technical interviews, implemented in C# with clarity and intention:

- Array-based problems
- String manipulation
- Hash-based patterns
- Clean separation between logic and execution
- Emphasis on readability and reasoning, not memorization

Each algorithm is implemented as a pure `Solve` method, with execution handled separately.

---

### 3. Evolution Path (Planned)

As the project evolves, it will naturally expand toward:

- More advanced C# features
- Better application structure
- Backend development with ASP.NET Core
- Preparation for cloud-native and service-based architectures

The focus remains on **progressive learning**, not premature complexity.

---

## Project Structure

```bash
CodingAssessment
│
├── Program.cs
│
├── Fundamentals
│   ├── VariablesAndTypes.cs
│   ├── StringsAndInterpolation.cs
│   ├── EscapeSequences.cs
│   ├── ArithmeticAndCasting.cs
│   └── ControlExercises
│       └── GradesCalculator.cs
│
├── Exercises
│   ├── Arrays
│   │   ├── TwoSum.cs
│   │   └── ContainsDuplicate.cs
│   ├── Strings
│   │   ├── IsPalindrome.cs
│   │   └── FirstNonRepeatedChar.cs
│   └── Hashing
│
├── course-c-sharp.csproj
└── .gitignore

```

## Project Structure

- `Program.cs`: single entry point and CLI router  
- `Fundamentals/`: C# language fundamentals and syntax refreshers  
- `Exercises/`: algorithmic exercises organized by pattern  
- `bin/`, `obj/`: build artifacts (ignored)  

---

## How to Run

This project uses a single `Program.cs` and runs different modules via command-line arguments.

From the project root:

## Run Fundamentals

```bash
dotnet run variables
dotnet run strings
dotnet run escape
dotnet run arithmetic
dotnet run grades
```

## Run Algorithms

```bash
dotnet run containsduplicate
dotnet run twosum
dotnet run palindrome
dotnet run firstunique
```

Running without arguments will display the available options.

## Project Rules

Generated files (bin/, obj/) are never committed

One project → one Program.cs

Logic (Solve) is separated from execution (Run)

Every change must have a clear purpose

Commits should be small, descriptive, and intentional

Code should be readable without external explanation

## Notes

This repository prioritizes clarity, intent, and learning depth over speed or volume.
It is designed to reflect professional engineering standards, even in a learning context.
