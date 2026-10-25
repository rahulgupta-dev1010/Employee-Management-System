# Employee Management System

A C# console application that demonstrates core .NET concepts
using one simple Employee domain.

## Tech
- C# / .NET Framework 4.8
- Visual Studio 2022

## How to run
1. Clone the repo: `git clone https://github.com/rahulgupta-dev1010/Employee-Management-System.git`
2. Open `Employee Management System.sln` in Visual Studio
3. Press **F5**

## Where each concept lives

| Concept | Folder / File |
|---|---|
| Abstract class | `AbstractClass/Person.cs` |
| Interface | `Interfaces/IWorker.cs` |
| Inheritance & polymorphism | `Models/Employee.cs`, `Models/Manager.cs` |
| Generics (Repository pattern) | `Repository/` |
| Delegates | `Delegates/SalaryDelegate.cs` |
| Func / Action / Predicate | `Func Action Predicate/` |
| LINQ | `LINQ/LINQ_Demo.cs` |
| Async / Await | `Async & Await/` |
| Dictionary, Queue, Stack | `Dictionary/`, `Queue/`, `Stack/` |

## What I learned
- I learned how an abstract class and an interface are different, and how inheritance lets `Employee` and `Manager` share code.
- I practised LINQ to filter, sort and group employee data, and used a generic repository to store objects.
- I tried delegates, `Func`/`Action`/`Predicate`, async/await, and the `Dictionary`, `Queue` and `Stack` collections.
- This was my first project to practise C# topics for interviews, and I plan to make it interactive next.

## Planned improvements
- [ ] Interactive console menu
- [ ] Move to .NET 8
- [ ] Unit tests with xUnit