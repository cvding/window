@echo off

set projpath=%1
set expath=%2

echo [Export the Project]
echo ====================
echo *-Created By @dddz-*
if not exist %expath% mkdir %expath%
if not exist %expath%\inc mkdir %expath%\inc
if not exist %expath%\lib mkdir %expath%\lib
if not exist %expath%\bin mkdir %expath%\bin

if exist %projpath%Bin\*.dll (
	copy /y %projpath%Bin\*.dll %expath%\bin\
)

if exist %projpath%Bin\*.exe (
	copy /y %projpath%Bin\*.exe %expath%\bin\
)

if exist %projpath%Bin\*.lib (
	copy /y %projpath%Bin\*.lib %expath%\lib\
)

if exist %projpath%..\Include\*.h** (
	copy %projpath%..\Include\*.* %expath%inc\*.*
)

echo [Export the Project]