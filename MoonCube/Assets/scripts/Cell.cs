using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;



//____________________________________________
//____________________________________________
//______________________Cell Class____________
//____________________________________________


public class Cell {
	public List<int> bits;
	public double fitness;

	public Cell() {
		Initialize ();
	}

	public Cell(int numBits) {
		Initialize ();

		for (int i = 0; i < numBits; i++) {
            		System.Random randomNumberGen = new System.Random(DateTime.Now.GetHashCode() 
						* SystemInfo.processorFrequency.GetHashCode());

		        bits.Add(randomNumberGen.Next(0, 2));
		}
	}

	private void Initialize() {
		fitness = 0;
		bits = new List<int> ();
	}
}
