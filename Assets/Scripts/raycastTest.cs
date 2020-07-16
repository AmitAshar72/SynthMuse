//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;

//public class raycastTest : MonoBehaviour {
//    //GameObject go;

//    //OVRPlayerController l;
//    LineRenderer L;
//   // Camera cam;
//    void start()
//    {
//        //l = GetComponent<OVRPlayerController>();
//        L = GetComponent<LineRenderer>();
//       // cam = GetComponent<OVRCameraRig>();
//    }
//	// Update is called once per frame
//	void Update () {
//        var ray = L.transform.position;
//        RaycastHit hit;
//        //if (Physics.Raycast(transform.position, transform.forward, out hit, 100.0f))
//        //{
//        //    if (hit.collider != null)
//        //    {
//        //        if (OVRInput.Get(OVRInput.Button.PrimaryIndexTrigger))
//        //        {
//        //            go = hit.transform.gameObject;
//        //            float dist = hit.distance;
//        //            Debug.Log("HIT: "+ go.name);
//        //            Debug.Log("HIT Distance: " + dist);
//        //            //o.SetActive(false);
//        //        }
//        //    }
//        //}
//        if (Physics.Raycast(ray, out hit))
//        {
//            var selection = hit.transform;
//            Debug.Log("OBJ: " + selection.gameObject);
//        }     
//    }
//}
