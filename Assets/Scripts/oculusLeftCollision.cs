using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class oculusLeftCollision : MonoBehaviour {
    public collisionDetection colLeft;
    void OnTriggerEnter(Collider other)
    {
        colLeft.collisionManager(other.gameObject);
    }
}
