using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class GamePlay : MonoBehaviour
{
    public FishTank FishTank;
    public Ocean Ocean;
    public FishManager FishManager;
    public Fish[] allFish = new Fish[] { };
    public List<Fish> NewFish = new List<Fish>(); 

    public float length = 0;
    public int Value = 0;




    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(" Tutorial");

        Debug.Log("Press and hold 'SPACEBAR' to start fishing");

        Debug.Log(" Press 'A' to catch or 'D' to throw back ");

        




    }

    // Update is called once per frame
    void Update()
    {
        


        if (Input.GetKeyDown(KeyCode.Space)) 
        {

            Debug.Log("You started fishing");
        }

        if (Input.GetKey(KeyCode.Space)) 
        {

            Debug.Log("You feel a big bite " +  " 'RELEASE SPACEBAR' "  );
        
        }


        if (Input.GetKeyUp(KeyCode.Space))
        {

            Debug.Log( "you caught a fish " + "Press 'W' Reel it in ");
        }

        if (Input.GetKeyDown(KeyCode.W))
        {

            length = Random.Range(0.5f, 21f);

            Value = (int)(length * 50f);

            Debug.Log("You caught a... " + allFish[Random.Range(0, 5)].fishName + " The length is  " + length + "'" + " , The value is $" + Value); 

        }

        if (Input.GetKeyDown(KeyCode.A))
        {
            Debug.Log("You put the fish in your Fish Tank");
            

        }

        if(Input.GetKeyDown(KeyCode.D))
        {

            Debug.Log("You threw the fish back");
        }

 
        
    
    }
}

