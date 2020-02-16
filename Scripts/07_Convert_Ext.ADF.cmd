@Echo off
REM Convert to Amiga Extended .ADF (Protected)
F:\gw\HxCFloppyEmulator_soft_beta\HxCFloppyEmulator_Software\Windows\hxcfe -finput:%1 -foutput:%1.ext.adf -conv:AMIGA_EXTADF 

REM FOR AMIGA:
REM F:\gw\HxCFloppyEmulator_soft_beta\HxCFloppyEmulator_Software\Windows\hxcfe.exe -finput:%1 -foutput:%1.adf -conv:AMIGA_ADF

REM FOR ATARI ST:
REM F:\gw\HxCFloppyEmulator_soft_beta\HxCFloppyEmulator_Software\Windows\hxcfe.exe -finput:%1 -foutput:%1.st -conv:ATARIST_ST
REM F:\gw\HxCFloppyEmulator_soft_beta\HxCFloppyEmulator_Software\Windows\hxcfe.exe -finput:%1 -foutput:%1.stx -conv:ATARIST_STX

echo.
pause