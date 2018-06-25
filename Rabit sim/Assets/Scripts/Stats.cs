using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stats : PathFinder {

    //Houd verschillende stats bij.

    [Header("Character stats")]
    public float hunger;
    public float thirst;
    public float sleepyness;
    public float age;
    
    public float health = 100;

    public override void Update()
    {
        base.Update();
        hunger += Time.deltaTime;
        thirst += Time.deltaTime;
        sleepyness += Time.deltaTime;
    }
}
