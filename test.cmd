@echo off

set configuration=%1
if "%1"=="" set configuration=Debug

%USERPROFILE%\.nuget\packages\xunit.runner.console\2.2.0\tools\xunit.console.exe test\IharBury.Expressions.Tests\bin\%configuration%\net462\IharBury.Expressions.Tests.dll
%USERPROFILE%\.nuget\packages\xunit.runner.console\2.2.0\tools\xunit.console.exe test\IharBury.Expressions.Tests\bin\%configuration%\net45\IharBury.Expressions.Tests.dll

pushd test\IharBury.Expressions.Tests
dotnet test --framework netcoreapp1.0 --configuration %configuration%
popd