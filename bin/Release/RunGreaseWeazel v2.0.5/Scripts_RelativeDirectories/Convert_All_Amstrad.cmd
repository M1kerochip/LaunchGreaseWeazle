@Echo off
Echo.
Echo This script takes a SuperCard Pro file, and uses HxC Floppy Emulator software to create a disk picture, data picture and various disk images.
Echo.
Echo HxC Floppy Emulator software is available from: https://hxc2001.com/download/floppy_drive_emulator/
Echo.
Echo Using the latest beta of HxC is recommended. (And is available from: https://hxc2001.com/download/floppy_drive_emulator/HxCFloppyEmulator_soft_beta.zip )
Echo.
Echo.
Echo BMP to PNG conversion is with nConvert, from XnSoft, makers of XnView and XnViewMP.
Echo.

REM Convert to Amstrad DSK image (For emulators etc)
HxCFloppyEmulator_soft_beta\HxCFloppyEmulator_Software\Windows\hxcfe -finput:%1 -foutput:%1.dsk -conv:AMSTRADCPC_DSK

REM Create BMP of disk data
HxCFloppyEmulator_soft_beta\HxCFloppyEmulator_Software\Windows\hxcfe -finput:%1 -foutput:%1.01_disk_HxC.bmp -conv:BMP_DISK_IMAGE

REM Convert BMP to PNG
nconvert\nconvert.exe -out png -o "%1".01_disk_HxC.png "%1".01_disk_HxC.bmp

REM Delete BMP  (Remove these lines if nConvert isn't installed!!!)
del "%1".01_disk_HxC.bmp /F /Q

REM Create BMP of disk data
HxCFloppyEmulator_soft_beta\HxCFloppyEmulator_Software\Windows\hxcfe -finput:%1 -foutput:%1.02_data_HxC.bmp -conv:BMP_IMAGE

REM Convert BMP to PNG
nconvert\nconvert.exe -out png -o "%1".02_data_HxC.png "%1".02_data_HxC.bmp

REM Delete BMP (Remove these lines if nConvert isn't installed!!!)
del "%1".02_data_HxC.bmp /F /Q

REM Convert to HFE v3 .hfe image (For Gotek etc running Flash Floppy, HxC etc)
HxCFloppyEmulator_soft_beta\HxCFloppyEmulator_Software\Windows\hxcfe -finput:%1 -foutput:%1.HxC_HFEv3.hfe -conv:HXC_HFEV3

