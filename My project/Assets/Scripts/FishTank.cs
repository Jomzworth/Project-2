using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FishTank : MonoBehaviour
{
    public List<Fish> allFish = new List<Fish>(); 


    public void Catch()
    {
        Debug.Log("Caught Fish");

    }

    public void Throwback() 
    {

        Debug.Log("Threw fish back ");

    
    }


}
