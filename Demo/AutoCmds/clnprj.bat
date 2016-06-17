@echo off
set proj=%1
echo begin clean the dir : [%proj%]

for /R %proj% %%s in (bin) do ( 
	if exist %%s (
		del /q %%s\*.*
		echo clean == [%%s]
	)
)
echo istop clean the [Bin]

echo begin clean the [debug] and [release]
for /R %proj% %%s in (Debug,debug,Release,release) do ( 
	if exist %%s (
		rd /q /s %%s
		echo clean == [%%s]
	)
)
echo istop clean the [debug] and [release]

echo begin clean the [ipch]
for /R %proj% %%s in (ipch) do ( 
	if exist %%s (
		rd /q /s %%s
		echo clean == [%%s]
	)
)
echo istop clean the [ipch]

echo begin clean the [*.sdf] and [*.opensdf]
for /R %proj% %%s in (*.sdf,*.opensdf,*.pdb,*.ipch) do ( 
	if exist %%s (
		del /q %%s
		echo clean == [%%s]
	)
)
echo istop clean the [*.sdf] and [*.opensdf]

echo over clean the dir : [%proj%]