using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Background : MonoBehaviour
{
    //available to edit in Unity
    [SerializeField] public static float backgroundScrollSpeed = 1f;
    //classifying the meterial
    Material backgroundMeterial;
    //the background movement
    Vector2 offset;

    // Start is called before the first frame update
    void Start()
    {
        //get the renderer meterial of the background
        backgroundMeterial = GetComponent<Renderer>().material;
        //it will scroll on the y-axis
        offset = new Vector2(0f, backgroundScrollSpeed);
    }

    // Update is called once per frame
    void Update()
    {
        backgroundMeterial.mainTextureOffset += offset * Time.deltaTime;
    }
}
