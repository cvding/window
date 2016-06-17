#include <stdio.h>
#include <stdlib.h>
#include <stdint.h>

int32_t xvmClean(const char *dir,const char *file)
{
	char cmd[512];

	sprintf(cmd,"@echo off && for /R %s %%s in (%s) do (if exist %%s (del /q %%s && echo del %%s))",dir,file);

	return system(cmd);
}

int32_t xvmDels(const char *dir,const char *file)
{
	char cmd[512];

	sprintf(cmd,"@echo off && for /R %s %%s in (%s) do (if exist %%s (rd /q /s %%s))",dir,file);

	return system(cmd);
}

int main()
{
	xvmClean("z:/","*.*");
	xvmDels("z:/","good");
	return 0;
}