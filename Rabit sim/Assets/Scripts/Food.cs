using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Food : MonoBehaviour {

    //Spreekt voorzich.

    public string objName;
    public float nutritionValue;

    public void OnCollisionStay(Collision collision)
    {
        
        if(collision.gameObject.GetComponent<Rabbit>() != null)
        {
            
            if (true)
            {
                
                collision.gameObject.GetComponent<Rabbit>().hunger -= nutritionValue * Random.Range(0.9f, 1.1f);
                Destroy(this.gameObject);
            }           
        }
    }
}
