using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rabbit : Brain {

    //Dit script kijkt naar zijn parent Brain en voert de functies uit die bij de task horen.

    public override void Update()
    {
        base.Update();

        if(task == Task.eat)
        {
            FindCarrot();
        }
        else if(task == Task.drink)
        {
            FindWater();
        }
        else if(task == Task.sleep)
        {
            GotoBase();
        }

        //Als het konijn teveel hunger of thirst heeft, gaat health omlaag.
        if (hunger >= 100 || thirst >= 100)
        {
            health -= Time.deltaTime * 5;   
            if(health <= 0)
            {
                Die();
            }
        }
        else
        {
            if (health < 100)
            {
                health += Time.deltaTime;
            }               
        }

        /*
        if (hunger >= 90)
        {
            //FindToCanibalize();
            //scrapped content, no sweet bunnyflesh for you.
        }
        */
    }

    //Gebruikt de functie in Pathfinding en overload die met de tag "Carrot"
    public void FindCarrot()
    {
        if(myTarget == null)
        {
            if(FindClosest("Carrot") != null)
            {
                myTarget = FindClosest("Carrot").transform;
            }
            
        }       
    }

    //Zelfde maar dan met water.
    public void FindWater()
    {
        if (myTarget == null)
        {
            if (FindClosest("Water") != null)
            {
                myTarget = FindClosest("Water").transform;
            }

        }
    }

    //Base is static.
    public void GotoBase()
    {
        myTarget = bunnyBase;
    }

    public void Patrol()
    {
        //Zou hier linecasts kunnen maken om het konijn te laten roamen.
        //Niet belangrijk voor de opdracht.
    }

    public void Die()
    {
        Destroy(this.gameObject);
    }

    //Cut
    public void FindToCanibalize()
    {      
        if (myTarget == null)
        {         
            if (FindClosest("Rabbit") != null)
            {               
                myTarget = FindClosest("Rabbit").transform;
            }
        }
    }
}
