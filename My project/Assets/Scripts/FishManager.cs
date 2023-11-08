using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FishManager : MonoBehaviour
{
    public GameObject COD ; 
    public GameObject CatFish ; 
    public GameObject Tuna ; 
    public GameObject Salmon ; 
    public GameObject Baramundi ; 


    // Start is called before the first frame update
    void Start()
    {
        Instantiate(COD) ;
        Instantiate (CatFish);
        Instantiate (Tuna) ;
        Instantiate (Salmon);
        Instantiate (Baramundi);



    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
