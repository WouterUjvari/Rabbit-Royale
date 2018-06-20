using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedChanger : MonoBehaviour {


    public float accel = 1;

    private void Update()
    {
        Time.timeScale = accel;
    }
}
