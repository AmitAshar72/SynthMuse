using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class oculusRightCollision : MonoBehaviour {
    public collisionDetection colRight;
    void OnTriggerEnter(Collider other)
    {
        colRight.collisionManager(other.gameObject);
    }
}
