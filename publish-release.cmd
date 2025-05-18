@echo off
REM Publish ClassicUO Release build to ./publish directory

setlocal
set SOLUTION=ClassicUO.sln
set PROJECT=src\ClassicUO.Client\ClassicUO.Client.csproj
set OUTDIR=publish
set RUNTIME=win-x64

REM Restore dependencies

dotnet restore %SOLUTION%

REM Build in Release mode

dotnet build %SOLUTION% -c Release

REM Publish the client as a self-contained single-file exe

dotnet publish %PROJECT% -c Release -r %RUNTIME% --self-contained true /p:PublishSingleFile=true -o %OUTDIR%

@echo.
@echo Publish complete. Output is in .\%OUTDIR%\
endlocal 