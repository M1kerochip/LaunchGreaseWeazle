@Echo off
REM Create BMP of disk data
F:\gw\HxCFloppyEmulator_soft_beta\HxCFloppyEmulator_Software\Windows\hxcfe -finput:%1 -foutput:%1.01_disk_HxC.bmp -conv:BMP_DISK_IMAGE

REM Convert BMP to PNG
F:\gw\nconvert\nconvert.exe -out png -o "%1".01_disk_HxC.png "%1".01_disk_HxC.bmp

REM Delete BMP
del "%1".01_disk_HxC.bmp /F /Q