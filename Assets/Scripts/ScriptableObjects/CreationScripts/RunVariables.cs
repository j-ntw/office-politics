using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.TextCore.Text;

[CreateAssetMenu(fileName = "RunVariables", menuName = "ScriptableObjects/RunVariables")]
public class RunVariables : ScriptableObject
{
    // Tracks dynamic values for each Run
    public ABCConsumable[] consumableObjects;


    public int performancePoints;

    public void Init()
    {
        // start of whole game, not level
        consumableObjects = new ABCConsumable[]
        { new KitKat(2), new Coffee(4), new KitKat(1) };
    }
}

public enum EvadeType
{
    Dash,
    Parry
}