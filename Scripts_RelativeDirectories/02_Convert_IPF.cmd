@Echo off
HxCFloppyEmulator_soft_beta\HxCFloppyEmulator_Software\Windows\hxcfe.exe -finput:%1 -foutput:%1.HxC.ipf -conv:SPS_IPF

REM FOR AMIGA:
REM HxCFloppyEmulator_soft_beta\HxCFloppyEmulator_Software\Windows\hxcfe.exe -finput:%1 -foutput:%1.HxC.adf -conv:AMIGA_ADF

REM FOR ATARI ST:
REM HxCFloppyEmulator_soft_beta\HxCFloppyEmulator_Software\Windows\hxcfe.exe -finput:%1 -foutput:%1.HxC.st -conv:ATARIST_ST
REM HxCFloppyEmulator_soft_beta\HxCFloppyEmulator_Software\Windows\hxcfe.exe -finput:%1 -foutput:%1.HxC.stx -conv:ATARIST_STX

echo.
REM pause