using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Water : MonoBehaviour {

    [Header("If drinking")]
    
    public float hydrationValue;

    public void OnTriggerStay(Collider collision)
    {
        
        if (collision.gameObject.GetComponent<Rabbit>() != null)
        {
            
            if (collision.gameObject.GetComponent<Rabbit>().myTarget == this.gameObject.transform)
            {
                
                collision.gameObject.GetComponent<Rabbit>().thirst -= hydrationValue * Time.deltaTime * Random.Range(0.9f, 1.1f);
            }
        }
    }
}
