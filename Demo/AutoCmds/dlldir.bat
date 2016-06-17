@REM @Author: 18840
@REM @Date:   2016-04-13 10:50:07
@REM @Last Modified by:   18840
@REM Modified time: 2016-04-13 11:59:59

::copy To The Bin path

@echo off
set cpath=%1
set opath=%2

echo [Depend The Current Director DLL Head]
echo [Created By dddz : 2016\4\13]
echo ========================
if not exist %opath% (
	set \p opath="input the original bin path : "
)

if not exist %cpath% mkdir %cpath%
for /R %opath% %%i in (*.dll) do (
	copy %%i %cpath%
)

echo [Depend The Current Director DLL Tail]