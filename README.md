# error MSB4181: The "CompileXaml" task returned false but did not log
Trying to reproduce MSB4181 "CompileXaml" error in Visual Studio.

 App                                       | Version
-------------------------------------------|---------------------
Windows                                    | 10 Pro (18363.1016) 
Visual Studion Community 2019              | 16.7.1
Microsoft.UI.Xaml                          | 2.4.3
Microsoft.NETCore.UniversalWindowsPlatform | 6.2.10



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
1. Try to package it
1. Get `error MSB4181: The "CompileXaml" task returned false but did not log`

---

#### Fix
1. Delete `/obj` folder
1. Try to package

OR

1. Build your project from a Developer Command prompt with this command: `msbuild /p:AppxBundlePlatforms=x86 /p:Platform=x86 /p:Configuration=Release /p:BuildAppxUploadPackageForUap=true /bl`
