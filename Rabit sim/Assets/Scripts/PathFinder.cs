using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class PathFinder : MonoBehaviour {
    

    [Header("Pathfinding")]
    public NavMeshAgent myAgent; 
    
    public Transform myTarget;

    public Transform bunnyBase;



    private void Start()
    {
        myAgent = GetComponent<NavMeshAgent>();
        bunnyBase = GameObject.FindGameObjectWithTag("BunnyBase").transform;
    }

    public virtual void Update()
    {
        

        if (myTarget != null)
        {
            myAgent.SetDestination(myTarget.position);
        }
    }

    public GameObject FindClosest(string taggetWith)
    {
        
        GameObject[] gos;
        gos = GameObject.FindGameObjectsWithTag(taggetWith);
        GameObject closest = null;
        float distance = Mathf.Infinity;
        Vector3 position = transform.position;
        foreach (GameObject go in gos)
        {
            Vector3 diff = go.transform.position - position;
            float curDistance = diff.sqrMagnitude;
            if (curDistance < distance)
            {
                closest = go;
                distance = curDistance;
            }
        }
        return closest;
    }
}
