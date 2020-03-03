@Echo off
F:\gw\HxCFloppyEmulator_soft_beta\HxCFloppyEmulator_Software\Windows\hxcfe.exe -finput:%1 -foutput:%1.HxC.st -conv:ATARIST_ST

REM FOR AMIGA:
REM F:\gw\HxCFloppyEmulator_soft_beta\HxCFloppyEmulator_Software\Windows\hxcfe.exe -finput:%1 -foutput:%1.HxC.adf -conv:AMIGA_ADF

REM FOR ATARI ST:
REM F:\gw\HxCFloppyEmulator_soft_beta\HxCFloppyEmulator_Software\Windows\hxcfe.exe -finput:%1 -foutput:%1.HxC.st -conv:ATARIST_ST
REM F:\gw\HxCFloppyEmulator_soft_beta\HxCFloppyEmulator_Software\Windows\hxcfe.exe -finput:%1 -foutput:%1.HxC.stx -conv:ATARIST_STX

echo.
REM pause