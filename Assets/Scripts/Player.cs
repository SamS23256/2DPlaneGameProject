using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    //giving xMin and xMax a type
    float xMin, xMax, yMin, yMax;
    float laserSpeed = 20f;

    //makes them editable from Unity
    [SerializeField] float padding = 0.5f;
    [SerializeField] float playerSpeed = 13f;

    [SerializeField] int playerHealth = 50;

    [SerializeField] GameObject deathSound;

    [SerializeField] AudioClip playerDeathSound;
    [SerializeField] [Range(0, 1)] float playerdthvl = 1f;

    // Start is called before the first frame update
    void Start()
    {
        SetBoundaries();
    }

    // Update is called once per frame
    void Update()
    {
        Movement();
    }

    public int GetHealth()
    {
        return playerHealth;
    }

    //reduces player health when a gameObject which has a DamageDealer component
    private void OnTriggerEnter2D(Collider2D collision)
    {
        DamageDealer dmg = collision.gameObject.GetComponent<DamageDealer>();

        if(dmg != null)
        {
            ProcessHit(dmg);
        }
    }

    private void ProcessHit(DamageDealer dmg)
    {
        playerHealth -= dmg.GetDMG();

        if  (playerHealth < 0)
        {
            playerHealth = 0;
            Destroy(gameObject);
            AudioSource.PlayClipAtPoint(playerDeathSound, Camera.main.transform.position, playerdthvl);
            FindObjectOfType<Levels>().LoadGameOver();
        }
    }

    void SetBoundaries()
    {
        //getting the camera from the hierarchy
        Camera viewCamera = Camera.main;
        //setting the min and max of x
        xMin = viewCamera.ViewportToWorldPoint(new Vector3(0, 0, 0)).x + padding;
        xMax = viewCamera.ViewportToWorldPoint(new Vector3(1, 0, 0)).x - padding;
        yMin = viewCamera.ViewportToWorldPoint(new Vector3(0, 0, 0)).y + padding;
        yMax = viewCamera.ViewportToWorldPoint(new Vector3(0, 1, 0)).y - padding;

    }

    void Movement()
    {
        //setting a variable for the input "Horizontal" and making it move
        var deltaX = Input.GetAxis("Horizontal") * Time.deltaTime * playerSpeed;
        //stores the new position in newXPos and claping the Player between the  xMin and xMax
        var newXPos = Mathf.Clamp(transform.position.x + deltaX, xMin, xMax);

        var deltaY = Time.deltaTime * Background.backgroundScrollSpeed;
        var newYPos = Mathf.Clamp(transform.position.y + deltaY, yMin, yMax);

        //updating the Player movement with the newXPos while keeping the y-axis the same
        transform.position = new Vector2(newXPos, newYPos);
    }
}
