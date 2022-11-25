using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Obstacles Wave List")]
public class WaveList : ScriptableObject
{
    //enemy to spawn in wave
    [SerializeField] GameObject obstaclePrefab;

    //encapsulate the obstacles fab
    public GameObject GetObstacles()
    {
        return obstaclePrefab;
    }

    //the waypoints where the obstacles moves
    [SerializeField] GameObject obstaclesRoute;

    //ecapsulate the waveList
    public List<Transform> GetPathsList()
    {
        //creates a new List in the WaveList
        List<Transform> pathList = new List<Transform>();

        //get the obstaclesRoute into the waveList
        foreach (Transform child in obstaclesRoute.transform)
        {
            pathList.Add(child);
        }

        return pathList;
    }

    [SerializeField] float spawnTime = 0.3f;

    //encapsulating spawntime
    public float GetSpawnTime()
    {
        return spawnTime;
    }

    //enemy spawn in wave
    [SerializeField] int spawnCount = 8;

    //encapsulate obstaclesSpawn
    public int GetObstaclesSpawn()
    {
        return spawnCount;
    }

    //enemy speed
    [SerializeField] float obstaclesSpeed = 3f;

    //encapsulating obstaclesSpeed
    public float ObstaclesSpeed()
    {
        return obstaclesSpeed;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
