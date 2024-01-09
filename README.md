![build](https://github.com/amlsantos/tennis-kata-refactoring/actions/workflows/build.yml/badge.svg)
![test](https://github.com/amlsantos/tennis-kata-refactoring/actions/workflows/test.yml/badge.svg)

## Tennis kata

### Tennis Scoring System

The code in this kata simulates a simplified tennis scoring system, including the logic for scoring and determining the winner of a tennis match. The goal is to refactor and improve the codebase while maintaining the functionality of the tennis game.

### Goals

1. **Improve Code Readability**: Enhance the clarity of the code by improving variable names, method names, and overall structure.

2. **Eliminate Code Duplication**: Identify and remove redundant or duplicated code.

3. **Increase Testability**: Make the code more testable by reducing dependencies and improving modularity.

4. **Remove Primitive Obsession by Introducing a Value Object**: Identify places where primitive types could be replaced with a value object to encapsulate related behavior and improve expressiveness.

5. **Apply Design Patterns**: Consider using the factory design pattern, to improve the overall design of the tennis scoring system.

### Refactoring Techniques

- **Rename Fields**: Update field names to be more descriptive and reflect their purpose.

- **Rename Methods**: Improve method names to better convey their functionality and purpose.

- **Extract Methods**: Identify code blocks that can be extracted into separate methods for better organization and reusability.

- **Remove Temp Variables**: Eliminate unnecessary temporary variables and simplify code.

- **Unroll Loop**: Simplify loops and remove unnecessary iterations for improved performance and readability.

- **Replace Conditional with Polymorphism**: Use polymorphism to replace conditional statements and improve the extensibility of the code.

## Project Structure

```plaintext
tennis-refactoring-kata/
|-- src/
|   |-- Domain/
|       |-- TennisGame.cs
|   |-- UI/
|       |-- Program.cs
|-- tests/
|   |-- UnitTests/
|       |-- TennisGameTests.cs
|-- .gitignore
|-- README.md
|-- LICENSE
```

## How to Use

1. Clone or download the Tennis Refactoring Kata repository:

    ```bash
    git clone https://github.com/amlsantos/tennis-kata-refactoring.git
    cd tennis-kata-refactoring
    dotnet run --project .\UI\UI.csproj
    ```

2. Review the existing code in the `Tennis` namespace.

3. Identify areas for improvement and apply refactoring techniques.

4. Run tests to ensure that the functionality remains unchanged.

5. Aim for clean, maintainable, and elegant code.

## Inspiration

Explore the [Path To Programming playlist](https://www.youtube.com/playlist?list=PLjprPuM411xXTcvhXNc_iiUNL8l6hErm8) for additional insights and inspiration for this refactoring exercise.

## Acknowledgments

- The Tennis Refactoring Kata concept is widely used for practicing refactoring and clean coding.
- Original kata details: [Tennis Kata on kata-log.rocks](https://kata-log.rocks/tennis-kata).
- Original repo: [emilybache](https://github.com/emilybache/Tennis-Refactoring-Kata/tree/main/csharp).

