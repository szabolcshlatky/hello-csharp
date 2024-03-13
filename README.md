# C# Learning notes

## CLI (Command Line Interface) commands

- `dotnet` ## to see the list of commands
- `dotnet new console -n <project>` ## to create a new console project
- `dotnet run` ## to run the project

## App structure

- helloworld/ : This is the root directory of your application.
  - helloworld.csproj : This is the project file which contains information about the project and how to build it. It includes references to dependencies, build instructions, and other project metadata.
  - Program.cs : This is the main entry point of your application. It contains the `Main` method which is the first method that gets called when you run your application.
  - README.md : This is a markdown file where you can write documentation about your project.
  - bin/ : This (binaries) directory contains the compiled output of your project when you build it. It's created automatically when you build your project.
  - obj/ : This directory is used by the .NET build system to hold temporary files and other files needed to compile your project. It's also created automatically when you build your project.

## Debug

Press `F5` in VSCode to start debugging.

## Browser

Web Assembly helps us to run C# in the browser.
Try: [text](https://learn.microsoft.com/en-us/dotnet/csharp/tour-of-csharp/tutorials/hello-world?tutorial-step=1)
