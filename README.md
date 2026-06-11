# C# (.NET) Development: Learning & Exercises

Welcome! This repository is a progressive log of my journey learning C# and the .NET ecosystem. It contains hands-on exercises covering language fundamentals, object-oriented programming (OOP), type safety, event-driven design, generics, and design patterns.

***

## 🛠️ Project Structure

All projects are organized under a single Visual Studio solution: `Nmt.Exercises.slnx`. Each project focuses on a specific learning milestone:

1. **[Nmt.Exercises.Console_01](./Nmt.Exercises.Console_01)**
   * **Focus:** Console basics, arrays, loops, and input validation.
2. **[Nmt.Exercises.Console_02](./Nmt.Exercises.Console_02)**
   * **Focus:** Working with command-line arguments, generic lists (`List<T>`), and dynamic string parsing.
3. **[Nmt.Exercises.Delegate](./Nmt.Exercises.Delegate)**
   * **Focus:** Understanding C# delegates, signature matching rules, and dynamic method execution.
4. **[Nmt.Exercises.Delegate_02](./Nmt.Exercises.Delegate_02)**
   * **Focus:** Callback delegation, passing method references as parameters, and writing reusable filter methods.
5. **[Nmt.Exercises.Delegate_03](./Nmt.Exercises.Delegate_03)**
   * **Focus:** Event-driven programming, implementing the publisher-subscriber pattern, and raising events safely.
6. **[Nmt.Exercises.Delegate_04](./Nmt.Exercises.Delegate_04)**
   * **Focus:** Advanced events using custom `EventArgs`, backing fields, and managing multiple subscribers.
7. **[Nmt.Exercises.DesignPattern_01](./Nmt.Exercises.DesignPattern_01)**
   * **Focus:** Implementing the Singleton Pattern using a centralized configuration manager.
8. **[Nmt.Exercises.DesignPattern_02](./Nmt.Exercises.DesignPattern_02)**
   * **Focus:** Implementing the Observer Pattern with Bitcoin price trackers notifying registered investors.
9. **[Nmt.Exercises.DesignPattern_03](./Nmt.Exercises.DesignPattern_03)**
   * **Focus:** Implementing the Factory Method Pattern to decouple payment processing logic from specific payment methods (CreditCard, PayPal, Crypto).
10. **[Nmt.Exercises.Generic_01](./Nmt.Exercises.Generic_01)**
    * **Focus:** Introduction to Generics with a basic generic envelope class.
11. **[Nmt.Exercises.Generic_02](./Nmt.Exercises.Generic_02)**
    * **Focus:** Writing generic methods, value/reference types, and C# parameter references using the `ref` keyword.
12. **[Nmt.Exercises.Generic_03](./Nmt.Exercises.Generic_03)**
    * **Focus:** Creating a generic repository with type constraints (`where T : class`), target-typed object initialization, and collection helpers.

***

## 📚 Key C# / .NET Core Concepts Covered

* **Type Safety & Data Types:** Value types vs. reference types, string manipulation, and arithmetic.
* **Control Flow & Input Processing:** Capturing console inputs, preventing parse crashes, and validation.
* **Functional Delegation:** Using delegates as type-safe method pointers to write flexible, extensible code.
* **Event-Driven Architectures:** Building systems that communicate via notifications, encapsulating state changes, and protecting event handlers.
* **Encapsulation & State Management:** Using C# properties with backing fields to regulate state and trigger side-effects.
* **Design Patterns:** Implementing classic Creational and Behavioral patterns in C# using interfaces, abstract classes, and properties.
* **Generics:** Creating type-safe generic classes and methods, applying constraints, object initializers, and modern `new()` syntax.

***

## 🚀 How to Run the Projects

### Option A: Using Visual Studio 2022

1. Open the solution file: `Nmt.Exercises.slnx`.
2. In the **Solution Explorer**, right-click the project you want to run.
3. Select **Set as Startup Project**.
4. Press `F5` or click **Start** to run the program.

### Option B: Using the .NET Core CLI

1. Open your terminal at the root directory of the repository (where the `.slnx` file is located).
2. Build the entire solution:
   ```bash
   dotnet build
   ```
3. Run a specific project (replace `Nmt.Exercises.Console_01` with any other project name):
   ```bash
   dotnet run --project Nmt.Exercises.Console_01
   ```

***

## 🏁 Learning Milestones

Keep track of the programming concepts and C# features mastered in this repository:

* [x] **C# Basics & Console Applications:**
  * [x] Basic arrays & conditional loops
  * [x] Command-line arguments parsing
  * [x] Terminal input validation & parsing error prevention
* [x] **Data Collections & Memory Models:**
  * [x] Understanding Value types vs. Reference types
  * [x] Working with generic lists (`List<T>`)
* [x] **Delegates & Callback Delegation:**
  * [x] Custom delegate declarations & signature matching
  * [x] Passing method references as arguments (callbacks)
  * [x] Writing reusable collection filter methods
* [x] **Event-Driven Programming:**
  * [x] Implementing the Publisher-Subscriber pattern
  * [x] Custom event arguments (`EventArgs`)
  * [x] Event raising safety & encapsulation of event handlers
* [x] **Encapsulation & State Management:**
  * [x] C# auto-properties and backing fields
  * [x] Triggering custom side effects on property assignment
* [x] **Design Patterns:**
  * [x] Singleton Pattern (Global thread-safe instance access)
  * [x] Observer Pattern (Publisher-subscriber model using interfaces)
  * [x] Factory Method Pattern (Decoupling object instantiation using abstract classes)
* [x] **C# Generics:**
  * [x] Designing Generic classes & Generic methods
  * [x] Passing parameters by reference using `ref`
  * [x] Applying type constraints (`where T : class`)
  * [x] Object Initializers & target-typed new (`new()`) expressions
