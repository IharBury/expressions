@echo off

set configuration=%1
if "%1"=="" set configuration=Debug

rd artifacts\test \S \Q >nul 2>nul

md artifacts\test >nul 2>nul

md artifacts\test\net46 >nul 2>nul
copy artifacts\bin\IharBury.Expressions.Tests\%configuration%\net46\IharBury.Expressions.Tests.dll artifacts\test\net46 >nul 2>nul
copy %USERPROFILE%\.dnx\packages\xunit\1.9.2\lib\net20\*.* artifacts\test\net46 >nul 2>nul
copy artifacts\bin\IharBury.Expressions\%configuration%\dotnet5.1\IharBury.Expressions.dll artifacts\test\net46 >nul 2>nul
copy %USERPROFILE%\.dnx\packages\System.Reflection.TypeExtensions\4.0.0\lib\net46\System.Reflection.TypeExtensions.dll artifacts\test\net46 >nul 2>nul
%USERPROFILE%\.dnx\packages\xunit.runner.console\2.1.0\tools\xunit.console.exe artifacts\test\net46\IharBury.Expressions.Tests.dll

md artifacts\test\net45 >nul 2>nul
copy artifacts\bin\IharBury.Expressions.Tests\%configuration%\net45\IharBury.Expressions.Tests.dll artifacts\test\net45 >nul 2>nul
copy %USERPROFILE%\.dnx\packages\xunit\1.9.2\lib\net20\*.* artifacts\test\net45 >nul 2>nul
copy artifacts\bin\IharBury.Expressions\%configuration%\dotnet5.1\IharBury.Expressions.dll artifacts\test\net45 >nul 2>nul
copy %USERPROFILE%\.dnx\packages\System.Reflection.TypeExtensions\4.0.0\lib\net46\System.Reflection.TypeExtensions.dll artifacts\test\net45 >nul 2>nul
%USERPROFILE%\.dnx\packages\xunit.runner.console\2.1.0\tools\xunit.console.exe artifacts\test\net45\IharBury.Expressions.Tests.dll

md artifacts\test\net40 >nul 2>nul
copy artifacts\bin\IharBury.Expressions.Tests\%configuration%\net40\IharBury.Expressions.Tests.dll artifacts\test\net40 >nul 2>nul
copy %USERPROFILE%\.dnx\packages\xunit\1.9.2\lib\net20\*.* artifacts\test\net40 >nul 2>nul
copy artifacts\bin\IharBury.Expressions\%configuration%\net40\IharBury.Expressions.dll artifacts\test\net40 >nul 2>nul
%USERPROFILE%\.dnx\packages\xunit.runner.console\2.1.0\tools\xunit.console.exe artifacts\test\net40\IharBury.Expressions.Tests.dll

md artifacts\test\net35 >nul 2>nul
copy artifacts\bin\IharBury.Expressions.Tests\%configuration%\net35\IharBury.Expressions.Tests.dll artifacts\test\net35 >nul 2>nul
copy %USERPROFILE%\.dnx\packages\xunit\1.9.2\lib\net20\*.* artifacts\test\net35 >nul 2>nul
copy artifacts\bin\IharBury.Expressions\%configuration%\net35\IharBury.Expressions.dll artifacts\test\net35 >nul 2>nul
%USERPROFILE%\.dnx\packages\xunit.runner.console\2.1.0\tools\xunit.console.exe artifacts\test\net35\IharBury.Expressions.Tests.dll

%USERPROFILE%\.dnx\runtimes\dnx-coreclr-win-x64.1.0.0-rc1-final\bin\dnx --project test\IharBury.Expressions.Tests test

%USERPROFILE%\.dnx\runtimes\dnx-clr-win-x64.1.0.0-rc1-final\bin\dnx --project test\IharBury.Expressions.Tests test
