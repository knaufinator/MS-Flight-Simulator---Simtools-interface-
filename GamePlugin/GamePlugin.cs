﻿
using Game_PluginAPI;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Numerics;

namespace FS2020_GamePlugin
{
    public class GamePlugin : IPlugin_Game
    {

        private const string _PluginAuthorsName = "value1, yobuddy";
        private const string _GameName = "FS2020";
        private const string _ProcessName = "FlightSimulator";
        private const string _Port = "20777";
        private const bool _RequiresPatchingPath = false;
        private const bool _RequiresSecondCheck = false;
        private const string _PluginOptions = "";
        private const bool _Enable_MemoryMap = false;
        private const string _MMF_Name = "NULL";
        private const bool _Enable_MemoryHook = false;
        private const uint _MemHook_Roll = 0;
        private const uint _MemHook_Pitch = 0;
        private const uint _MemHook_Heave = 0;
        private const uint _MemHook_Yaw = 0;
        private const uint _MemHook_Sway = 0;
        private const uint _MemHook_Surge = 0;
        private const uint _MemHook_Extra1 = 0;
        private const uint _MemHook_Extra2 = 0;
        private const uint _MemHook_Extra3 = 0;
        private const bool _DOF_Support_Roll = true;
        private const bool _DOF_Support_Pitch = true;
        private const bool _DOF_Support_Heave = true;
        private const bool _DOF_Support_Yaw = true;
        private const bool _DOF_Support_Sway = true;
        private const bool _DOF_Support_Surge = true;
        private const string _DOF_Support_Extra1 = "RotAccelX";
        private const string _DOF_Support_Extra2 = "RotAccelY";
        private const string _DOF_Support_Extra3 = "RotAccelZ";
        private const bool _Enable_DashBoard = false;
        private const bool _Enable_GameVibe = false;
        private GamePlugin.OutSim MyOutsim_Internal;
        public string Dash_1_Output;
        public string Dash_2_Output;
        public string Dash_3_Output;
        public string Dash_4_Output;
        public string Dash_5_Output;
        public string Dash_6_Output;
        public string Dash_7_Output;
        public string Dash_8_Output;
        public string Dash_9_Output;
        public string Dash_10_Output;
        public string Dash_11_Output;
        public string Dash_12_Output;
        public string Dash_13_Output;
        public string Dash_14_Output;
        public string Dash_15_Output;
        public string Dash_16_Output;
        public string Dash_17_Output;
        public string Dash_18_Output;
        public string Dash_19_Output;
        public string Dash_20_Output;
        public double Roll_Output;
        public double Pitch_Output;
        public double Heave_Output;
        public double Yaw_Output;
        public double Sway_Output;
        public double Surge_Output;
        public double Extra1_Output;
        public double Extra2_Output;
        public double Extra3_Output;
        public double Roll_MemHook;
        public double Pitch_MemHook;
        public double Heave_MemHook;
        public double Yaw_MemHook;
        public double Sway_MemHook;
        public double Surge_MemHook;
        public double Extra1_MemHook;
        public double Extra2_MemHook;
        public double Extra3_MemHook;
        public double Roll_MemMap;
        public double Pitch_MemMap;
        public double Heave_MemMap;
        public double Yaw_MemMap;
        public double Sway_MemMap;
        public double Surge_MemMap;
        public double Extra1_MemMap;
        public double Extra2_MemMap;
        public double Extra3_MemMap;
        public string Vibe_1_Output;
        public string Vibe_2_Output;
        public string Vibe_3_Output;
        public string Vibe_4_Output;
        public string Vibe_5_Output;
        public string Vibe_6_Output;
        public string Vibe_7_Output;
        public string Vibe_8_Output;
        public string Vibe_9_Output;

        public GamePlugin()
        {
            this.MyOutsim_Internal = new GamePlugin.OutSim();
            this.Dash_1_Output = "";
            this.Dash_2_Output = "";
            this.Dash_3_Output = "";
            this.Dash_4_Output = "";
            this.Dash_5_Output = "";
            this.Dash_6_Output = "";
            this.Dash_7_Output = "";
            this.Dash_8_Output = "";
            this.Dash_9_Output = "";
            this.Dash_10_Output = "";
            this.Dash_11_Output = "";
            this.Dash_12_Output = "";
            this.Dash_13_Output = "";
            this.Dash_14_Output = "";
            this.Dash_15_Output = "";
            this.Dash_16_Output = "";
            this.Dash_17_Output = "";
            this.Dash_18_Output = "";
            this.Dash_19_Output = "";
            this.Dash_20_Output = "";
            this.Roll_Output = 0.0;
            this.Pitch_Output = 0.0;
            this.Heave_Output = 0.0;
            this.Yaw_Output = 0.0;
            this.Sway_Output = 0.0;
            this.Surge_Output = 0.0;
            this.Extra1_Output = 0.0;
            this.Extra2_Output = 0.0;
            this.Extra3_Output = 0.0;
            this.Roll_MemHook = 0.0;
            this.Pitch_MemHook = 0.0;
            this.Heave_MemHook = 0.0;
            this.Yaw_MemHook = 0.0;
            this.Sway_MemHook = 0.0;
            this.Surge_MemHook = 0.0;
            this.Extra1_MemHook = 0.0;
            this.Extra2_MemHook = 0.0;
            this.Extra3_MemHook = 0.0;
            this.Roll_MemMap = 0.0;
            this.Pitch_MemMap = 0.0;
            this.Heave_MemMap = 0.0;
            this.Yaw_MemMap = 0.0;
            this.Sway_MemMap = 0.0;
            this.Surge_MemMap = 0.0;
            this.Extra1_MemMap = 0.0;
            this.Extra2_MemMap = 0.0;
            this.Extra3_MemMap = 0.0;
            this.Vibe_1_Output = "";
            this.Vibe_2_Output = "";
            this.Vibe_3_Output = "";
            this.Vibe_4_Output = "";
            this.Vibe_5_Output = "";
            this.Vibe_6_Output = "";
            this.Vibe_7_Output = "";
            this.Vibe_8_Output = "";
            this.Vibe_9_Output = "";
        }

        public void GameStart()
        {
        }

        public void GameStop()
        {
        }

        public void Process_MemoryHook()
        {
        }

        public void Process_MemoryMap()
        {
        }

        public void Process_PacketRecieved(string text)
        {
            try
            {
                if (text.StartsWith("S:") & text.EndsWith(":E"))
                {

                    //toSend[0] = accelVector.X.ToString("n14");
                    //toSend[1] = accelVector.Y.ToString("n14");
                    //toSend[2] = accelVector.Z.ToString("n14");

                    //toSend[3] = filteredRotAccelVector.Z.ToString("n14");
                    //toSend[4] = filteredRotAccelVector.Z.ToString("n14");
                    //toSend[5] = filteredRotAccelVector.Z.ToString("n14");

                    string[] strlist = text.Split(':');

                    this.Surge_Output = Double.Parse(strlist[1]);
                    this.Sway_Output = Double.Parse(strlist[2]);
                    this.Heave_Output = Double.Parse(strlist[3]);

                    this.Extra1_Output = Double.Parse(strlist[4]);//rxX
                    this.Extra2_Output = Double.Parse(strlist[5]);//rxY
                    this.Extra3_Output = Double.Parse(strlist[6]);//trac

                    this.Pitch_Output = Double.Parse(strlist[7]);
                    this.Roll_Output = Double.Parse(strlist[8]);
                    this.Yaw_Output = Double.Parse(strlist[9]);


                }
            }
            catch (Exception)
            {
                this.Surge_Output = 1;//flag to me that it be broke...

            }
        }

        [MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.NoOptimization)]
        public bool PatchGame(string MyPath, string MyIp)
        {
            bool flag = true;
            try
            {
             
            }
            catch (Exception ex)
            {
             
            }
            return flag;
        }

        public void UnPatchGame(string MyPath)
        {
         
        }

        [MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.NoOptimization)]
        private void UnPatch(string MyPath)
        {
          
        }


        public string Get_PluginVersion()
        {
            return Assembly.GetExecutingAssembly().GetName().Version.ToString();
        }

        public string GetDOFsUsed()
        {
            return true.ToString() + "," + true.ToString() + "," + true.ToString() + "," + true.ToString() + "," + true.ToString() + "," + true.ToString() + "," + "RotX".ToString() + "," + "RotY".ToString().ToString() + "," + "RotZ".ToString().ToString();
        }

        public void ResetDOFVars()
        {
            this.Roll_Output = 0.0;
            this.Pitch_Output = 0.0;
            this.Heave_Output = 0.0;
            this.Yaw_Output = 0.0;
            this.Sway_Output = 0.0;
            this.Surge_Output = 0.0;
            this.Extra1_Output = 0.0;
            this.Extra2_Output = 0.0;
            this.Extra3_Output = 0.0;
        }

        public void ResetMapVars()
        {
            this.Roll_MemMap = 0.0;
            this.Pitch_MemMap = 0.0;
            this.Heave_MemMap = 0.0;
            this.Yaw_MemMap = 0.0;
            this.Sway_MemMap = 0.0;
            this.Surge_MemMap = 0.0;
            this.Extra1_MemMap = 0.0;
            this.Extra2_MemMap = 0.0;
            this.Extra3_MemMap = 0.0;
        }

        public void ResetHookVars()
        {
            this.Roll_MemHook = 0.0;
            this.Pitch_MemHook = 0.0;
            this.Heave_MemHook = 0.0;
            this.Yaw_MemHook = 0.0;
            this.Sway_MemHook = 0.0;
            this.Surge_MemHook = 0.0;
            this.Extra1_MemHook = 0.0;
            this.Extra2_MemHook = 0.0;
            this.Extra3_MemHook = 0.0;
        }

        public void ResetDashVars()
        {
            this.Dash_1_Output = "";
            this.Dash_2_Output = "";
            this.Dash_3_Output = "";
            this.Dash_4_Output = "";
            this.Dash_5_Output = "";
            this.Dash_6_Output = "";
            this.Dash_7_Output = "";
            this.Dash_8_Output = "";
            this.Dash_9_Output = "";
            this.Dash_10_Output = "";
            this.Dash_11_Output = "";
            this.Dash_12_Output = "";
            this.Dash_13_Output = "";
            this.Dash_14_Output = "";
            this.Dash_15_Output = "";
            this.Dash_16_Output = "";
            this.Dash_17_Output = "";
            this.Dash_18_Output = "";
            this.Dash_19_Output = "";
            this.Dash_20_Output = "";
        }

        public void ResetVibeVars()
        {
            this.Vibe_1_Output = "";
            this.Vibe_2_Output = "";
            this.Vibe_3_Output = "";
            this.Vibe_4_Output = "";
            this.Vibe_5_Output = "";
            this.Vibe_6_Output = "";
            this.Vibe_7_Output = "";
            this.Vibe_8_Output = "";
            this.Vibe_9_Output = "";
        }

        public string PluginAuthorsName
        {
            get
            {
                return "value1, yobuddy";
            }
        }

        public string Name
        {
            get
            {
                return _GameName;
            }
        }

        public string ProcessName
        {
            get
            {
                return _ProcessName;
            }
        }

        public string Port
        {
            get
            {
                return _Port;
            }
        }

        public bool Enable_MemoryMap
        {
            get
            {
                return false;
            }
        }

        public bool Enable_MemoryHook
        {
            get
            {
                return false;
            }
        }

        public bool RequiresPatchingPath
        {
            get
            {
                return _RequiresPatchingPath;
            }
        }

        public bool RequiresSecondCheck
        {
            get
            {
                return _RequiresSecondCheck;
            }
        }

        public bool Enable_DashBoard
        {
            get
            {
                return _Enable_DashBoard;
            }
        }

        public bool Enable_GameVibe
        {
            get
            {
                return _Enable_GameVibe;
            }
        }

        public double Get_RollOutput()
        {
            return this.Roll_Output;
        }

        public double Get_PitchOutput()
        {
            return this.Pitch_Output;
        }

        public double Get_HeaveOutput()
        {
            return this.Heave_Output;
        }

        public double Get_YawOutput()
        {
            return this.Yaw_Output;
        }

        public double Get_SwayOutput()
        {
            return this.Sway_Output;
        }

        public double Get_SurgeOutput()
        {
            return this.Surge_Output;
        }

        public double Get_Extra1Output()
        {
            return this.Extra1_Output;
        }

        public double Get_Extra2Output()
        {
            return this.Extra2_Output;
        }

        public double Get_Extra3Output()
        {
            return this.Extra3_Output;
        }

        public string Get_Dash_1_Output()
        {
            return this.Dash_1_Output;
        }

        public string Get_Dash_2_Output()
        {
            return this.Dash_2_Output;
        }

        public string Get_Dash_3_Output()
        {
            return this.Dash_3_Output;
        }

        public string Get_Dash_4_Output()
        {
            return this.Dash_4_Output;
        }

        public string Get_Dash_5_Output()
        {
            return this.Dash_5_Output;
        }

        public string Get_Dash_6_Output()
        {
            return this.Dash_6_Output;
        }

        public string Get_Dash_7_Output()
        {
            return this.Dash_7_Output;
        }

        public string Get_Dash_8_Output()
        {
            return this.Dash_8_Output;
        }

        public string Get_Dash_9_Output()
        {
            return this.Dash_9_Output;
        }

        public string Get_Dash_10_Output()
        {
            return this.Dash_10_Output;
        }

        public string Get_Dash_11_Output()
        {
            return this.Dash_11_Output;
        }

        public string Get_Dash_12_Output()
        {
            return this.Dash_12_Output;
        }

        public string Get_Dash_13_Output()
        {
            return this.Dash_13_Output;
        }

        public string Get_Dash_14_Output()
        {
            return this.Dash_14_Output;
        }

        public string Get_Dash_15_Output()
        {
            return this.Dash_15_Output;
        }

        public string Get_Dash_16_Output()
        {
            return this.Dash_16_Output;
        }

        public string Get_Dash_17_Output()
        {
            return this.Dash_17_Output;
        }

        public string Get_Dash_18_Output()
        {
            return this.Dash_18_Output;
        }

        public string Get_Dash_19_Output()
        {
            return this.Dash_19_Output;
        }

        public string Get_Dash_20_Output()
        {
            return this.Dash_20_Output;
        }

        public double Get_RollMemHook()
        {
            return this.Roll_MemHook;
        }

        public double Get_PitchMemHook()
        {
            return this.Pitch_MemHook;
        }

        public double Get_HeaveMemHook()
        {
            return this.Heave_MemHook;
        }

        public double Get_YawMemHook()
        {
            return this.Yaw_MemHook;
        }

        public double Get_SwayMemHook()
        {
            return this.Sway_MemHook;
        }

        public double Get_SurgeMemHook()
        {
            return this.Surge_MemHook;
        }

        public double Get_Extra1MemHook()
        {
            return this.Extra1_MemHook;
        }

        public double Get_Extra2MemHook()
        {
            return this.Extra2_MemHook;
        }

        public double Get_Extra3MemHook()
        {
            return this.Extra3_MemHook;
        }

        public double Get_RollMemMap()
        {
            return this.Roll_MemMap;
        }

        public double Get_PitchMemMap()
        {
            return this.Pitch_MemMap;
        }

        public double Get_HeaveMemMap()
        {
            return this.Heave_MemMap;
        }

        public double Get_YawMemMap()
        {
            return this.Yaw_MemMap;
        }

        public double Get_SwayMemMap()
        {
            return this.Sway_MemMap;
        }

        public double Get_SurgeMemMap()
        {
            return this.Surge_MemMap;
        }

        public double Get_Extra1MemMap()
        {
            return this.Extra1_MemMap;
        }

        public double Get_Extra2MemMap()
        {
            return this.Extra2_MemMap;
        }

        public double Get_Extra3MemMap()
        {
            return this.Extra3_MemMap;
        }

        public string Get_Vibe1_Output()
        {
            return this.Vibe_1_Output;
        }

        public string Get_Vibe2_Output()
        {
            return this.Vibe_2_Output;
        }

        public string Get_Vibe3_Output()
        {
            return this.Vibe_3_Output;
        }

        public string Get_Vibe4_Output()
        {
            return this.Vibe_4_Output;
        }

        public string Get_Vibe5_Output()
        {
            return this.Vibe_5_Output;
        }

        public string Get_Vibe6_Output()
        {
            return this.Vibe_6_Output;
        }

        public string Get_Vibe7_Output()
        {
            return this.Vibe_7_Output;
        }

        public string Get_Vibe8_Output()
        {
            return this.Vibe_8_Output;
        }

        public string Get_Vibe9_Output()
        {
            return this.Vibe_9_Output;
        }

        public void GameEnd()
        {

        }

        public string Get_Dash1_Output()
        {
            return Dash_1_Output;
        }

        public string Get_Dash2_Output()
        {
            return Dash_2_Output;
        }

        public string Get_Dash3_Output()
        {
            return Dash_3_Output;
        }

        public string Get_Dash4_Output()
        {
            return Dash_4_Output;
        }

        public string Get_Dash5_Output()
        {
            return Dash_5_Output;
        }

        public string Get_Dash6_Output()
        {
            return Dash_6_Output;
        }

        public string Get_Dash7_Output()
        {
            return Dash_7_Output;
        }

        public string Get_Dash8_Output()
        {
            return Dash_8_Output;
        }

        public string Get_Dash9_Output()
        {
            return Dash_9_Output;
        }

        public string Get_Dash10_Output()
        {
            return Dash_10_Output;
        }

        public string Get_Dash11_Output()
        {
            return Dash_11_Output;
        }

        public string Get_Dash12_Output()
        {
            return Dash_12_Output;
        }

        public string Get_Dash13_Output()
        {
            return Dash_13_Output;
        }

        public string Get_Dash14_Output()
        {
            return Dash_14_Output;
        }

        public string Get_Dash15_Output()
        {
            return Dash_15_Output;
        }

        public string Get_Dash16_Output()
        {
            return Dash_16_Output;
        }

        public string Get_Dash17_Output()
        {
            return Dash_17_Output;
        }

        public string Get_Dash18_Output()
        {
            return Dash_18_Output;
        }

        public string Get_Dash19_Output()
        {
            return Dash_19_Output;
        }

        public string Get_Dash20_Output()
        {
            return Dash_20_Output;
        }

        public void PatchPathInfo()
        {
           
        }

        public bool ValidatePatchPath(string MyPath)
        {
            return false;
        }

        public string PluginOptions
        {
            get
            {
                return "";
            }
        }

        public string GameName => _GameName;

        private struct OutSim
        {
            public byte bytTime1;
            public byte bytTime2;
            public byte bytTime3;
            public byte bytTime4;
            public float sngAVelocity0;
            public float sngAVelocity1;
            public float sngAVelocity2;
            public float sngOrientation0;
            public float sngOrientation1;
            public float sngOrientation2;
            public float sngAcceleration0;
            public float sngAcceleration1;
            public float sngAcceleration2;
            public float sngVelocity0;
            public float sngVelocity1;
            public float sngVelocity2;
            public byte bytPosition01;
            public byte bytPosition02;
            public byte bytPosition03;
            public byte bytPosition04;
            public byte bytPosition11;
            public byte bytPosition12;
            public byte bytPosition13;
            public byte bytPosition14;
            public byte bytPosition21;
            public byte bytPosition22;
            public byte bytPosition23;
            public byte bytPosition24;
            public long lngGameID;
        }
    }
}
