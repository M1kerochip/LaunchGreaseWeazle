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

REM Aufit: Create .stx, create protections.txt and create disk surface image:
Aufit-1.3\Aufit.exe -suffix aufit.1.3 -scale 1.4 -disk -protections -save stx %1

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

REM Convert to Atari .STX image (Protected)
HxCFloppyEmulator_soft_beta\HxCFloppyEmulator_Software\Windows\hxcfe -finput:%1 -foutput:%1.HxC.stx -conv:ATARIST_STX

REM Convert to Amiga .ADF (Unprotected)
HxCFloppyEmulator_soft_beta\HxCFloppyEmulator_Software\Windows\hxcfe -finput:%1 -foutput:%1.HxC.adf -conv:AMIGA_ADF

REM Convert to Amiga Extended .ADF (Protected) 
REM HxCFloppyEmulator_soft_beta\HxCFloppyEmulator_Software\Windows\hxcfe -finput:%1 -foutput:%1.HxC.extended.adf -conv:AMIGA_EXTADF 

REM Convert to .IPF
REM HxCFloppyEmulator_soft_beta\HxCFloppyEmulator_Software\Windows\hxcfe -finput:%1 -foutput:%1.HxC.ipf -conv:SPS_IPF

REM Show Info
REM HxCFloppyEmulator_soft_beta\HxCFloppyEmulator_Software\Windows\hxcfe -finput:%1 -foutput:%1.info_HxC.txt -infos

REM Convert to Atari .ST image (Unprotected)
HxCFloppyEmulator_soft_beta\HxCFloppyEmulator_Software\Windows\hxcfe -finput:%1 -foutput:%1.HxC.st -conv:ATARIST_ST



REM FOR AMIGA:
REM-==========-

REM Convert to Amiga .ADF (Unprotected)
REM HxCFloppyEmulator_soft_beta\HxCFloppyEmulator_Software\Windows\hxcfe -finput:%1 -foutput:%1.HxC.adf -conv:AMIGA_ADF

REM Convert to Amiga Extended .ADF (Protected) 
REM HxCFloppyEmulator_soft_beta\HxCFloppyEmulator_Software\Windows\hxcfe -finput:%1 -foutput:%1.HxC.extended.adf -conv:AMIGA_EXTADF 



REM FOR ATARI ST:
REM-=============-

REM Aufit: Create .stx, create protections.txt and create disk surface image:
REM Aufit-1.3\Aufit.exe -suffix aufit.1.3 -scale 1.4 -disk -protections -save stx %1

REM Convert to Atari .ST image (Unprotected)
REM HxCFloppyEmulator_soft_beta\HxCFloppyEmulator_Software\Windows\hxcfe -finput:%1 -foutput:%1.HxC.st -conv:ATARIST_ST

REM Convert to Atari .STX image (Protected)
REM HxCFloppyEmulator_soft_beta\HxCFloppyEmulator_Software\Windows\hxcfe -finput:%1 -foutput:%1.HxC.stx -conv:ATARIST_STX

REM pause