# String Data Type

C# is a strongly typed language and has a built in `ESLint`.
Check Program.cs code for syntax

## Declaration

With the `string` keyword, you can declare a string variable.
String variables are immutable, meaning that they cannot be changed after they are created.
The variables itself can be changed, but the original string remains the same in memory.

### Concatenation

You can concatenate strings using the `+` operator.

### Interpolation

You can use the `$` symbol to interpolate strings (template literals).

## Properties

`.Length` - returns the length number of the string.

## Methods

`.ToUpper()` - returns the string in uppercase.
`.ToLower()` - returns the string in lowercase.

`.Trim()` - removes whitespace from both ends of a string.
`.TrimStart()` - removes whitespace from the beginning of a string.
`.TrimEnd()` - removes whitespace from the end of a string.

`.Replace("part of the string", "replace it with this")` - replaces all specified value with another value in a string.

`.Contains("part of the string")` - returns true if the string contains the specified value, otherwise false.
`.StartsWith("part of the string")` - returns true if the string starts with the specified value, otherwise false.
`.EndsWith("part of the string")` - returns true if the string ends with the specified value, otherwise false.
