@echo off

if not exist obj md obj
cd obj
del *.* /q
cd ..

"%ProgramFiles(x86)%\MSBuild\14.0\Bin\MSBuild.exe" /p:Configuration=Release /t:Clean,Rebuild
if %errorlevel% neq 0 exit /b 1
"%VS140COMNTOOLS%..\IDE\CommonExtensions\Microsoft\TestWindow\vstest.console.exe" IharBury.Expressions.Tests\bin\Release\IharBury.Expressions.Tests.dll /InIsolation
if %errorlevel% neq 0 exit /b 2

cd obj
NuGet pack ..\IharBury.Expressions\IharBury.Expressions.csproj -Symbols
if %errorlevel% neq 0 exit /b 3
NuGet pack ..\IharBury.Expressions\IharBury.Expressions.csproj -Exclude **/*.pdb
if %errorlevel% neq 0 exit /b 4
