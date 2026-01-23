# C# Course – Language Fundamentals and Hands-On Practice

## Description

This repository is designed as a hands-on learning project to reinforce and deepen knowledge of **C#**, with a strong focus on language fundamentals, compile-time behavior, project structure, and good development practices.

The goal is not only to make code work, but to **understand how and why it works**, from the compiler’s perspective and through intentional design decisions.

This project serves as a learning log, technical reference, and foundation to regain or strengthen hands-on proficiency in C#, following a clear, incremental, and professional approach.

---

## Objectives

- Build a solid foundation in the C# language  
- Understand the C# type system and its compile-time behavior  
- Use explicit types and type inference (`var`) intentionally  
- Practice fundamentals through small, focused exercises  
- Maintain a clean and defensible project structure  
- Work with Git using disciplined workflows (branches, commits, PRs)  

---

## Learning Scope

This project follows a structured learning path focused on progressing from **C# language fundamentals** to **basic backend development with ASP.NET Core**, aligned with official learning modules.

### 1. C# Language Fundamentals (Console Applications)

This first phase focuses on mastering the core elements of the C# language through console applications, including:

- Writing first C# programs and understanding program structure  
- Creating and running C# console applications using the .NET CLI  
- Working with variables, literals, and data types  
- Understanding compile-time type inference (`var`) and explicit typing  
- Adding logic with conditionals and loops  
- Managing variable data and state  
- Creating and organizing methods  
- Debugging C# console applications  

All concepts are reinforced through small, focused exercises aimed at building fluency and confidence with the language.

---

### 2. Intermediate C# and Application Structure

As the fundamentals solidify, the focus expands to:

- Writing cleaner and more modular console applications  
- Improving code readability and maintainability  
- Applying basic organization and design principles  
- Using Git intentionally as part of the learning process  

This phase emphasizes *thinking in C#*, not just writing syntax.

---

### 3. Introduction to ASP.NET Core and Web APIs

Once the language foundation is established, the project evolves into backend development with ASP.NET Core:

- Creating Web APIs using ASP.NET Core controllers  
- Understanding request and response handling  
- Structuring simple APIs following .NET conventions  

This stage serves as an entry point into backend development, not as a full production-ready API.

---

### 4. Cloud-Native Foundations with .NET

The final stage introduces cloud-native concepts using .NET and ASP.NET Core:

- Understanding the basics of cloud-native application design  
- Exploring how .NET applications evolve beyond local execution  
- Preparing the ground for future scalability and service-based architectures  

---

## Scope Boundaries

To keep the learning focused and effective, this project intentionally does **not** include:

- Complex frontend frameworks  
- Advanced UI development  
- Heavy architectural abstractions  
- Production-level infrastructure or deployment pipelines  

The emphasis remains on **language mastery, fundamentals, and intentional progression**.

---

## Project Structure
```bash
/exercises
  /basic
    - print-literal-values.cs
    - ...
Program.cs
course-c-sharp.csproj
.gitignore
- `exercises/`: exercises organized by topic or level  
- `basic/`: language fundamentals (variables, types, literals, etc.)  
- `Program.cs`: entry point for execution and experimentation  
- `.gitignore`: excludes build artifacts (`bin/`, `obj/`)  
```

The structure may evolve as the learning path progresses.

---

## Project Rules

- Generated files (`bin/`, `obj/`) are never committed  
- Every change must have a clear purpose  
- Commits should be small and descriptive  
- Code should be understandable without external explanation  

---

## How to Run

From the project root:

```bash
dotnet run
