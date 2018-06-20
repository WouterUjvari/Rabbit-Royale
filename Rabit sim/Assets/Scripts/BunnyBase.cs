using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BunnyBase : MonoBehaviour {

    [Header("If sleeping")]

    public float sleepingrate;

    public void OnTriggerStay(Collider collision)
    {

        if (collision.gameObject.GetComponent<Rabbit>() != null)
        {

            if (collision.gameObject.GetComponent<Rabbit>().myTarget == this.gameObject.transform)
            {

                collision.gameObject.GetComponent<Rabbit>().sleepyness -= sleepingrate * Time.deltaTime * Random.Range(0.9f, 1.1f);
            }
        }
    }
}
