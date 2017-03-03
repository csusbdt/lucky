using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoubleArrayTest : MonoBehaviour
{
	public int row;
	public int column;
	public int objectType;

	public GameObject[,] doubleOrNothing = new GameObject [5,5];
	public GameObject[] testObj;


	// Use this for initialization
	void Start ()
    {
		SpawnLevel ();
	}
	
	// Update is called once per frame
	void Update ()
    {
		
	}

	void SpawnLevel()
	{
		row = 5;
		column = 5;
		for (int count = 0; count < row; count++) 
		{
			for (int i = 0; i < column; i++) 
			{
				objectType = Random.Range (0, 2);
				print (objectType);
				doubleOrNothing [count, i] = GameObject.Instantiate(testObj[objectType], new Vector3(count, i, 0.0f), Quaternion.identity);
				print (doubleOrNothing [count, i].transform.position);
				testObj[objectType].transform.Rotate(new Vector3(15.0f, 0.0f, 0.0f));
			}
		}
	}


}
