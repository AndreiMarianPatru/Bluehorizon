﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class PlayerStats : MonoBehaviour
{
    public static Vector3 position;
    public static Vector3 rotation;

    public static float TimeSpentInNormal;
    public static float TimeSpentInTwilight;
    public static float TimeSpentInTundra;
    public static float TimeSpentInSwamp;
    public static float TimeSpentInMountain;
    public static float TimeSpentInShallow;
    public static float TimeSpentInSunrise;

    public static string biome;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        position = gameObject.transform.position;
        rotation = gameObject.transform.rotation.eulerAngles;
        //Debug.Log(TimeSpentInNormal.ToString());
    }
    public void setPositionandRotation()
    {
        gameObject.transform.position = position;
        gameObject.transform.rotation.eulerAngles.Set(rotation.x, rotation.y, rotation.z);
    }

    public void QuitExport()
    {
        AnalyticsExport.SendToExport("Time spent in Normal biome "+TimeSpentInNormal.ToString()+" s");
        AnalyticsExport.SendToExport("Time spent in Mountain biome "+TimeSpentInMountain.ToString() + " s");
        AnalyticsExport.SendToExport("Time spent in Shallow biome "+TimeSpentInShallow.ToString() + " s");
        AnalyticsExport.SendToExport("Time spent in Sunrise biome "+TimeSpentInSunrise.ToString() + " s");
        AnalyticsExport.SendToExport("Time spent in Swamp biome "+TimeSpentInSwamp.ToString() + " s");
        AnalyticsExport.SendToExport("Time spent in Tundra biome "+TimeSpentInTundra.ToString() + " s");
        AnalyticsExport.SendToExport("Time spent in Twilight biome "+TimeSpentInTwilight.ToString() + " s");
        Debug.Log(AnalyticsExport.ExportData());
    }

    public String getBiome()
    {
        return biome;
    }
}
