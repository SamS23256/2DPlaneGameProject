using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageDealer : MonoBehaviour
{
    [SerializeField] int dmg = 1;

    //recieved dmg
    public int GetDMG()
    {
        return dmg;
    }

    //deletes the object
    public void Impact()
    {
        Destroy(gameObject);
    }
}
