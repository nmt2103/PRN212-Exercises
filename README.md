# C# (.NET) Development Learning & Exercises

This repository is dedicated to learning C# and the .NET runtime ecosystem. It acts as a progressive learning log, covering fundamentals of the C# language, object-oriented design, type safety, event-driven programming patterns, and software development workflows.

***

## 🛠️ Project Structure

The exercises in this workspace are organized under a single Visual Studio solution, Nmt.Exercises.slnx. Each project demonstrates a specific C#/.NET learning milestone:

1. **\[Nmt.Exercises.Console\_01]**
   * **Focus:** Console application basics, basic arrays, conditional statements, and robust input validation.
2. **\[Nmt.Exercises.Console\_02]**
   * **Focus:** Parsing and manipulating command-line arguments, working with generic lists (`List<T>`), and processing string inputs dynamically.
3. **\[Nmt.Exercises.Delegate]**
   * **Focus:** Understanding C# delegates, signature matching rules, declaring custom delegate types, and executing methods dynamically.
4. **\[Nmt.Exercises.Delegate\_02]**
   * **Focus:** Callback delegation, passing method references as parameters, and writing reusable filter methods.
5. **\[Nmt.Exercises.Delegate\_03]**
   * **Focus:** Event-driven programming, implementing the publisher-subscriber pattern, and raising events safely.
6. **\[Nmt.Exercises.Delegate\_04]**
   * **Focus:** Advanced event management, using custom event arguments (`EventArgs`), private backing fields, and managing multiple event subscribers.

***

## 📚 General C#/.NET Core Concepts Covered

* **Type Safety & Data Types:** Understanding value types vs. reference types, string manipulation, and double-precision arithmetic.
* **Control Flow & Input Processing:** Capturing terminal input, preventing parsing crashes, and validating strings.
* **Functional Delegation:** Using delegates as type-safe method pointers to write decoupled, extensible code.
* **Event-Driven Architectures:** Building systems that communicate via notifications, encapsulating state changes, and protecting event handlers from external modification.
* **Encapsulation & State Management:** Using C# properties with backing fields to regulate state and trigger side-effects.

***

## 🚀 How to Run the Projects

### Running via Visual Studio 2022

1. Open the solution file: Nmt.Exercises.slnx
2. In the **Solution Explorer**, right-click the specific project you want to run.
3. Select **Set as Startup Project**.
4. Press `F5` or click **Start** to run the program.

### Running via .NET Core CLI

1. Open your terminal at the root directory of the repository (where the `.slnx` file is located).
2. Restore package dependencies and compile the solution:
   ```bash
   dotnet build
   ```
3. Run a specific project (replace the project name as needed):
   ```bash
   dotnet run --project Nmt.Exercises.Console_01
   ```

***

## 🏁 Learning Milestones

Track your learning progress by checking off completed exercise projects:

* \[x] **Milestone 1:** `Nmt.Exercises.Console_01` (Arrays, Loops & Validation)
* \[x] **Milestone 2:** `Nmt.Exercises.Console_02` (Command-Line Arguments & Generic Lists)
* \[x] **Milestone 3:** `Nmt.Exercises.Delegate` (Custom Delegate Declaration & Signature Matching)
* \[x] **Milestone 4:** `Nmt.Exercises.Delegate_02` (Callback Delegation & Filtering List Elements)
* \[x] **Milestone 5:** `Nmt.Exercises.Delegate_03` (Basic Publisher-Subscriber Event System)
* \[x] **Milestone 6:** `Nmt.Exercises.Delegate_04` (Advanced Events, backing fields & custom EventArgs)
