using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Genome : MonoBehaviour
{
    public List<int> bits;
public double fitness;


    void Start()
    {
        
    }

     
    void Update()
    {
        fitness = 0;
	bits = new List<int> ();
    }
}
