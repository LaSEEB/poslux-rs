@ECHO OFF
set mypath=%cd%
START %mypath%\Stimulus\EO-EC\Builds\Builds.exe
TIMEOUT 5
neuxus %mypath%\Stimulus\acquire_data.py