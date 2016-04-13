# Avalon Compiler Projects

In this repository you will find two projects: advanced and basic. These projects are to be used with the Avalon Compiler (AC.exe). 

## The projects
### basic
A single page application with some inline C# code in the XAML file. Compiles to an exe application by default.

### advanced
A multi page application which allows navigating to a second page and back. Event handlers are included as a seperate code file. Compiles to an exe application by default.

## Compiling
Open a command prompt and browse to the location of AC.exe. (```Windows\Microsoft.NET\Avalon\```). Now execute 

    AC %path_to_project_folder%\project.lhproj
    
Depending on how you have configured debug info and package type, you will find your compiled Avalon application in a Debug or Retail folder.

## Compatibility
The current versions of both projects are strictly compatible with the Avalon Compiler found in Longhorn build 3683. Further changes to the project files are required to achieve compatibility with any other builds.



### Configuring the project
A wide range of settings can be configured by altering project.lhproj. For more information see  http://longhorn.ms/avalon-compiling-it ?

