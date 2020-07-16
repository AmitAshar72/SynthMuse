using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ovrIsGrabbed : MonoBehaviour {
    private OVRGrabbable ovr;
    string grabbedObj;
    // Use this for initialization
    void Start () {
        ovr = GetComponent<OVRGrabbable>();
    }
	
	// Update is called once per frame
	void Update () {
        // ovr.isGrabbed = false;
        if (ovr.isGrabbed)
        {
            grabbedObj = gameObject.name;
            Debug.Log("GRABBEDOBJ: " + grabbedObj);
        }
    }
}
