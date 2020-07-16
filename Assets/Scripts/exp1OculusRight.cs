using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class exp1OculusRight : MonoBehaviour {
    public testColldier rightCol;
    void OnTriggerEnter(Collider Rother)
    {
        rightCol.noteCollision(Rother.gameObject.name);
        //Debug.Log("Right Collision");
    }
}
