using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class exp1OculusLeft : MonoBehaviour {
    public testColldier leftCol;
    void OnTriggerEnter(Collider Lother)
    {
        leftCol.noteCollision(Lother.gameObject.name);
        //Debug.Log("Left Collision");
    }
}
