using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class instantiatePrefabLevel3 : MonoBehaviour {
    public GameObject[] lever= new GameObject[2];
  
    public string[] leverName;
	// Use this for initialization
	void Start () {
       
        leverName = new string[2] {"Frequency Lever","Index Lever" };
        Vector3 position = new Vector3(-2.0f , 1.0f, -3.0f);
        Quaternion rotation = Quaternion.identity;
        for (int i=0;i<2; i++)
        {
            position = new Vector3(-1.0f+(i*2), 1.0f, -3.0f);
            Instantiate(lever[i], position, rotation);
            lever[i].name = leverName[i];
        }

       GameObject.Find("Index Lever(Clone)").transform.Find("Handle").GetComponent<Renderer>().material.color = Color.blue;

    }

   
}
