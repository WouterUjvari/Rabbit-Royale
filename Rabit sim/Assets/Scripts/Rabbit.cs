using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rabbit : Brain {



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

    public void GotoBase()
    {
        myTarget = bunnyBase;
    }

    public void Patrol()
    {

    }

    public void Die()
    {
        Destroy(this.gameObject);
    }

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
