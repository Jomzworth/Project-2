using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ocean : MonoBehaviour
{

    public Fish[] allFish = new Fish[] { }; 
   
    // Start is called before the first frame update
    void Start()
    {
       //Debug.Log ("The first fish is " + allFish[0].fishName);

       // Debug.Log (allFish.Length);

       // Debug.Log ("The last fish is " + allFish[allFish.Length-1].fishName);


       //Debug.Log ("A Random Fish is " + allFish[Random.Range (0,5)].fishName);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
