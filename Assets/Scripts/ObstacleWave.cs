using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName ="Enemy Wave Settings")]
public class ObstacleWave : MonoBehaviour
{

    [SerializeField] GameObject enemyPrefab;

    public GameObject GetEnemyPrefab()
    {
        return enemyPrefab;
    }

    [SerializeField] GameObject enemyRoute;

    public List<Transform> GetWaypointsLog()
    {
        List<Transform> waveWaypointsLog = new List<Transform>();

        foreach (Transform child in enemyRoute.transform)
        {
            waveWaypointsLog.Add(child);
        }

        return waveWaypointsLog;
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
