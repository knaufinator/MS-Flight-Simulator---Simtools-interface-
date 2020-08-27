# MS-Flight-Simulator---Simtools-interface-

This is a VERY early release as QUICKLY as I could get it out so people can start flying around in a motion sim for Microsoft Flight Sim 2020

This project includes 2 parts

1) FS2020_GamePlugin = The Simtools plugin, compile this and drop the file FS2020_GamePlugin.dll into the SimTools plugin updater app to install it, patch it as normal.

2) Simvars = This is a Server application, this connects to MS Flight Simulator when you hit Connect, it Queries data from the game at 50Hz, its slow,.. i know... this is a proof of concept, there is a timer that sends to simtools over UDP the telemetry @1000Hz, so there is optimization to be done. I just wanted to get this out ASAP...
