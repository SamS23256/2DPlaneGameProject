using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyPath : MonoBehaviour
{

    [SerializeField] List<Transform> waypoints;

    int waypointNum = 0;

    // Start is called before the first frame update
    void Start()
    {
        transform.position = waypoints[0].transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void EnemyMovement()
    {
        if(waypointNum < waypoints.Count)
        {
            var finalPos = waypoints[waypointNum].transform.position;

            finalPos.z = 0f;


        }
    }

}
