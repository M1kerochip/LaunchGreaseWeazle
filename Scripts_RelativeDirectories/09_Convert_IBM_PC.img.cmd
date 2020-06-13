@Echo off
REM Convert to Amiga Extended .ADF (Protected)
HxCFloppyEmulator_soft_beta\HxCFloppyEmulator_Software\Windows\hxcfe -finput:%1 -foutput:%1.HxC.img -conv:RAW_IMG

echo.
REM pause