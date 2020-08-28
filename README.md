# MS-Flight-Simulator---Simtools-interface-

This is a VERY early release as QUICKLY as I could get it out so people can start flying around in a motion sim for Microsoft Flight Sim 2020

This project includes 2 parts

1) FS2020_GamePlugin = The Simtools plugin, compile this and drop the file FS2020_GamePlugin.dll into the SimTools plugin updater app to install it, patch it as normal.

2) Simvars = This is a Server application, this connects to MS Flight Simulator when you hit Connect, it Queries data from the game only at 10Hz, anything faster and it was slowing my PC down, so change that at your discretion.... this needs to be improved. take a stab...this is a modified app from the SDK, so it has a bunch more functionality in it than what we are using. dont hit anything else other than Connect.... after it opens up, and it should consume the data automagically..the simtools plugin should see the data as soon as you do.

There are prolly linking issues, i have included the SDK dlls needed to be in the directory of the exe, it is also pre-compiled in the debug folder

