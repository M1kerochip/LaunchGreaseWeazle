@Echo off
REM Create BMP of disk data
HxCFloppyEmulator_soft_beta\HxCFloppyEmulator_Software\Windows\hxcfe -finput:%1 -foutput:%1.02_data_HxC.bmp -conv:BMP_IMAGE

REM Convert BMP to PNG
nconvert\nconvert.exe -out png -o "%1".02_data_HxC.png "%1".02_data_HxC.bmp

REM Delete BMP
del "%1".02_data_HxC.bmp /F /Q