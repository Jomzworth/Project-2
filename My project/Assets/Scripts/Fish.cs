using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fish : MonoBehaviour
{
    public string fishName;
    public float length = 0;
    public int Value = 0;

    void Start()
    {

        length = Random.Range(0.5f, 21f);

        Value = (int)(length * 50f);
        

        
    }

     void Update()
    {

        

        
    }



}
