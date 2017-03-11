@echo off

call test.cmd Release

pushd src\IharBury.Expressions
dotnet pack --configuration Release --include-symbols
popd