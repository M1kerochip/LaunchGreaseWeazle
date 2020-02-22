@Echo off
REM Convert to Amiga Extended .ADF (Protected)
F:\gw\HxCFloppyEmulator_soft_beta\HxCFloppyEmulator_Software\Windows\hxcfe -finput:%1 -foutput:%1.img -conv:RAW_IMG

echo.
REM pause