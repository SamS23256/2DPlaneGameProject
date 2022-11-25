using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleSpawner : MonoBehaviour
{
    //Waves List
    [SerializeField] List<WaveList> pathList;

    [SerializeField] bool waveLoop = false;

    //start from path 0
    int pathCount = 0;

    //Start is called before the first frame update
    //IEnumerator Start()
    //{
    //    do
    //    {
    //        //setting the first path
    //        WaveList firstpath = pathList[pathCount];

    //        yield return StartCoroutine(SpawnWaves());
    //    }
    //    //when SpawnWaves() is done, check if the loop is true
    //    while (waveLoop);
    //}

    // Update is called once per frame
    void Update()
    {
        
    }

    //IEnumerator SpawnAllObstaclesInWaves(WaveList path)
    //{
    //    //spawns all obstacles from the path
    //    for (int enemyCount = 1; enemyCount <= path.GetObstaclesSpawn(); enemyCount++)
    //    {
    //        //spawn the obstacles at the first point, by getting the info from path
    //        GameObject newObject = Instantiate(path.GetObstacles(),
    //            path.GetPathsList()[0].transform.position,
    //            Quaternion.identity);

    //        //select and place the obstacle to the path

    //    }
    //}

    //IEnumerator SpawnWaves()
    //{
    //    //loop each path
    //    foreach (WaveList path in pathList)
    //    {
    //        //wait until all obsticles spawn
    //        yield return StartCoroutine(SpawnAllObstaclesInWaves(path));
    //    }
    //}
}
