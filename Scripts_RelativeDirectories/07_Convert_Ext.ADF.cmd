@Echo off
REM Convert to Amiga Extended .ADF (Protected)
HxCFloppyEmulator_soft_beta\HxCFloppyEmulator_Software\Windows\hxcfe -finput:%1 -foutput:%1.HxC.extended.adf -conv:AMIGA_EXTADF 

echo.
REM pause