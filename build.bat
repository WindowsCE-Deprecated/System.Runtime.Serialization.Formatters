@echo off

set SolutionDir=%~dp0
set SolutionName=SerializationFormatters
set Project=System.Runtime.Serialization.Formatters

REM Cleanup output directory
rmdir /s/q "%SolutionDir%Output" 2> nul
mkdir "%SolutionDir%Output"

CALL %SolutionDir%tools\build-wince.bat %SolutionDir% %SolutionName% %Project% || EXIT /B 1
REM CALL %SolutionDir%tools\build-dotnet.bat %SolutionDir% %Project% net35-cf || EXIT /B 1

echo build complete.
echo.
EXIT /B %ERRORLEVEL%
