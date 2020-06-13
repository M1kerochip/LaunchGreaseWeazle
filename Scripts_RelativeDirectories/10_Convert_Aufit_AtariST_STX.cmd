@Echo off
Echo.
Echo This script takes a SuperCard Pro file, and uses Aufit software to create a disk picture, protections text file and stx disk image.
Echo.
Echo Aufit is available from: 
Echo.

REM Aufit: Create .stx, create protections.txt and create disk surface image:
Aufit-1.3\Aufit.exe -suffix aufit.1.3 -scale 1.4 -disk -protections -save stx %1

REM pause