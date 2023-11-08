using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GamePlay : MonoBehaviour
{
    public FishTank FishTank;
    public Fish Fish;
    public Ocean Ocean;
    public FishManager FishManager; 






    // Start is called before the first frame update
    void Start()
    {
        




    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)) 
        {

            Debug.Log("You started fishing");
        }

        if (Input.GetKeyUp(KeyCode.Space))
        {

            Debug.Log("You feel a bite, Press LMB to catch fish ");
        }

        if (Input.GetKeyDown(KeyCode.Mouse0))
        {

            Debug.Log("You caught a " );


        }


    }
}

