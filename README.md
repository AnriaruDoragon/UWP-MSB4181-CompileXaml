# error MSB4181: The "CompileXaml" task returned false but did not log
Trying to reproduce MSB4181 "CompileXaml" error in Visual Studio.

**[microsoft/microsoft-ui-xaml Issuse #3067](https://github.com/microsoft/microsoft-ui-xaml/issues/3067)**

 App                                       | Version
-------------------------------------------|---------------------
Windows                                    | 10 Pro (18363.1016) 
Visual Studio                              | Community 2019 16.7.1
Microsoft.UI.Xaml                          | 2.4.3
Microsoft.NETCore.UniversalWindowsPlatform | 6.2.10

**[Broken `/obj` folder on Google Drive](https://drive.google.com/file/d/1jFlb95YUqrqg97Fg65MIhsDqzUO-6n3m/view?usp=sharing)**

---

#### Steps to reproduce error:
1. Create project
1. Add some elements with `x:Name`
1. Run it
1. Package it
1. Reload Studio
1. Change `x:Name` in elements or delete element
1. Run it
1. Everyting works  fine
1. Try to package project

OR

1. Clone project
1. Add broken `/obj` folder to your project, [Download from Google Drive](https://drive.google.com/file/d/1jFlb95YUqrqg97Fg65MIhsDqzUO-6n3m/view?usp=sharing)
1. Try to package project

---

#### Fix
1. Build your project from a Developer Command prompt with `msbuild` this command: `msbuild /p:AppxBundlePlatforms="x86|x64" /p:Platform=x86 /p:Configuration=Release /p:BuildAppxUploadPackageForUap=true /bl`

OR

1. Delete `/obj` folder
1. Try to package
