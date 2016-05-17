@echo off

call test.cmd

pushd src\IharBury.Expressions
dotnet pack --configuration Release
popd