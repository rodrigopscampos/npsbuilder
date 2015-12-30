# npsbuilder
Power Shell sample script to create Nuget Package.

The script is supposed to call msbuild for a collection of .csproj, set package version based on current date and mount a package.

At the top of the script file "Make.ps1". You must edit the variables accourding to your environment and packages customs.

You must also change the computer policy: "Set-ExecutionPolicy Unrestricted".

To use it, you have to execute the "Make.ps1" script from Windows Powershell or Visual Studio Package Manage Console.
