using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstaclePathing : MonoBehaviour
{
    //where the obstacle wants to go
    int waypointIndex = 0;

    //create a TransformList
    List<Transform> pathList;

    WaveList obstaclePathConfig;

    // Start is called before the first frame update
    void Start()
    {
        pathList = obstaclePathConfig.GetPathsList();
        //set the obstacle position to 0
        transform.position = pathList[0].transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        ObstacleMove();
    }

    //set up a path to spawn
    public void SetPathToSpawn(WaveList pathToSet)
    {
        obstaclePathConfig = pathToSet;
    }

    void ObstacleMove()
    {
        //if the lost point is not reached
        if(waypointIndex < pathList.Count)
        {
            //save the pathing in targetPoint
            var targetPoint = pathList[waypointIndex].transform.position;

            //make sure the obsticle is visible
            targetPoint.z = 0f;

            var movPerFrame = obstaclePathConfig.ObstaclesSpeed() * Time.deltaTime;
            //move the obstacle from postion towords target every frame
            transform.position = Vector2.MoveTowards(this.transform.position, targetPoint, movPerFrame);

            //if obsticle reaches point update the index
            if(transform.position == targetPoint)
            {
                waypointIndex++;
            }
        }

        //if obstacle moved to end point
        else
        {
            Destroy(gameObject);
        }
    }
}
