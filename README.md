# Visual Basic.NET utilities for students/teachers

This is a collection of VB.NET utilities I have created when I was teaching VB.NET in a secondary school.

## Download

- Binary (Compiled with VB 2010 with .NET Framework 4)

## About the utilities

### MsgBox Demo / InputBox Demo

As their name implies, they are used to demonstrate the capability of MsgBox and InputBox statements.

These two programs have two functions, namely

- To show the required MsgBox / InputBox.
- Generate VB.NET code for the said MsgBox / InputBox.

The programs are used myself to create the teacher’s version of VB.NET worksheet or exam papers. To take high quality screenshots, I recommend [Greenshot](http://getgreenshot.org/).

### Expression Evaluator

This program finds out the values of multiple VB.NET expressions. Enter one expression in a line, and the program will output the result in a corresponding line. The main use of the program is to create worksheets which ask students to evaluate VB.NET expressions. (Manual calculations are prone to errors.)

For example, you want to calculate the answers for the following:

| VB expression                                            | Result          |
|----------------------------------------------------------|-----------------|
| Strings.Right("polar", 2) &   Strings.Left("ease", 3)    | "areas"         |
| Len("--Computer Literacy--")                             | 21              |
| "S." &   Strings.Left("2A", 1)                           | "S.2"           |
| Mid("dictionary", 5, 3)                                  | "ion"           |
| UCase(LCase("Hello!"))                                   | "HELLO!"        |
| LCase(Trim("   Mr. Wood "))                              | "mr.   wood"    |
| Dim s As String = "Testing"<br>s = Mid(s, Len(s) - 2, 2) | "in"            |

The input of the program looks like this: (you need to remove <code>s =</code> in the last line.)
```vbnet
Strings.Right("polar", 2) & Strings.Left("ease", 3)
Len("--Computer Literacy--")
"S." & Strings.Left("2A", 1)
Mid("dictionary", 5, 3)
UCase(LCase("Hello!"))
LCase(Trim(" Mr. Wood "))
Dim s As String = "Testing"
Mid(s, Len(s) - 2, 2)
```

### Snippet runner

This program runs a VB.NET code snippet. The Console and Debug/Trace outputs are shown when you run the code snippet.

A preset Console input can be added when you execute the program, and the input can be dumped to the Console output, so the program appears to be executed like the actual VB.NET program.

At present, subroutines are not supported.