using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour {

    public GameObject item;
    public float frequency;
    private float timer;

    private void Update()
    {
        timer += Time.deltaTime;
        if(timer >= frequency)
        {
            timer = 0;
            GameObject g = Instantiate(item,transform);
            Destroy(g, 120);

        }
    }
}
