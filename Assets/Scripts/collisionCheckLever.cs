using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collisionCheckLever : MonoBehaviour {
    public bool isFreqLeverAttached, isIndLeverAttached;
    void Start()
    {
       isFreqLeverAttached = false;
       isIndLeverAttached = false;
     
    }
    
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Frequency Lever(Clone)")
        {
           other.transform.position = new Vector3(0.62f, 0.55f, -1.0f); //smoother motion
            other.transform.rotation = Quaternion.identity;
            isFreqLeverAttached = true;
        }
        if (other.gameObject.name == "Index Lever(Clone)")
        {
            other.transform.position = new Vector3(-0.92f, 0.55f, -1.0f);
            other.transform.rotation = Quaternion.identity;
            other.transform.Rotate(0.0f, 180.0f, 0.0f, Space.World);
            isIndLeverAttached = true;
        }
    }
}
