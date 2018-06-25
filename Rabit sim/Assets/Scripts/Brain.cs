using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Brain : Stats {

    //Dit scripts maakt de beslissingen van het konijn. 
    //Het inherit van Stats omdat stats invloed hebben op beslissingen.

    //Verschillende Tasks die het konijn kan hebben.
    public enum Task { patrol, drink, eat, sleep, flee };
    public Task task;

    //Alle ifstatements die bepalen welke task kan verandere in welke task, en welke requirements daarvoor zijn.
    //Patrol is neutral.
    //Patrol doet niks (wip?).
    //Requirements om terug naar patrol te gaan zijn vaak lager, zodat als het konijn eet, de kans groter is dat ie blijft eten.
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
