@echo off

set configuration=%1
if "%1"=="" set configuration=Debug

%USERPROFILE%\.nuget\packages\xunit.runner.console\2.1.0\tools\xunit.console.exe test\IharBury.Expressions.Tests\bin\%configuration%\net46\win7-x64\IharBury.Expressions.Tests.dll
%USERPROFILE%\.nuget\packages\xunit.runner.console\2.1.0\tools\xunit.console.exe test\IharBury.Expressions.Tests\bin\%configuration%\net45\win7-x64\IharBury.Expressions.Tests.dll
%USERPROFILE%\.nuget\packages\xunit.runner.console\2.1.0\tools\xunit.console.exe test\IharBury.Expressions.Tests\bin\%configuration%\net40\win7-x64\IharBury.Expressions.Tests.dll
%USERPROFILE%\.nuget\packages\xunit.runner.console\2.1.0\tools\xunit.console.exe test\IharBury.Expressions.Tests\bin\%configuration%\net40-client\win7-x64\IharBury.Expressions.Tests.dll
%USERPROFILE%\.nuget\packages\xunit.runner.console\2.1.0\tools\xunit.console.exe test\IharBury.Expressions.Tests\bin\%configuration%\net35\win7-x64\IharBury.Expressions.Tests.dll
%USERPROFILE%\.nuget\packages\xunit.runner.console\2.1.0\tools\xunit.console.exe test\IharBury.Expressions.Tests\bin\%configuration%\net35-client\win7-x64\IharBury.Expressions.Tests.dll

pushd test\IharBury.Expressions.Tests
dotnet test --runtime netcoreapp1.0 --framework netcoreapp1.0 --configuration %configuration%
popd