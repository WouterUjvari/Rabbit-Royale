using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Brain : Stats {

    public enum Task { patrol, drink, eat, sleep, flee };
    public Task task;

    public override void Update()
    {
        base.Update();

        if(task == Task.patrol)
        {
            if (hunger >= 50)
            {
                task = Task.eat;
            }
            if (thirst >= 40)
            {
                task = Task.drink;
            }
        }

        if(task == Task.eat)
        {

            if(hunger <= 40)
            {
                task = Task.patrol;              
            }
        }
        if(task == Task.drink)
        {
            if(thirst <= 30)
            {
                task = Task.patrol;
                myTarget = null;
            }
        }
        if(task == Task.patrol)
        {
            if(sleepyness >= 80)
            {
                task = Task.sleep;
            }
        }
        if(task == Task.sleep)
        {
            if(sleepyness <= 30)
            {
                task = Task.patrol;
                myTarget = null;
            }
        }


        
    }


}
