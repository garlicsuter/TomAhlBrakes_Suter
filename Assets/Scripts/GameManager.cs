using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject Car;
    public GameObject Wrench;
    //public GameObject[] nuts;


    // Start is called before the first frame update
    void Start()
    {
        Car = GameObject.FindGameObjectWithTag("Car");
        Wrench = GameObject.FindGameObjectWithTag("Wrench");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
