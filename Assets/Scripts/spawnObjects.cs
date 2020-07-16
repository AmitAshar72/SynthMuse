using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class spawnObjects : MonoBehaviour {

    public GameObject sine;
    public GameObject square;
    public GameObject triangle;
    //private LineRenderer lr;
    string childObject;
    //public instantiateNoteExp2 note;



    public GameObject[] musicBox = new GameObject[4];
    private string[] notename;
    Vector3 centerPos, addheight;
    float radius, angle;
    public bool isCollided=false;
    //private GameObject grabbedObj;
    Vector3 pos1, pos2, pos3;
    Quaternion rot;
    // Use this for initialization
     void Start () {
        //lr = GetComponent<LineRenderer>();

        pos1 = new Vector3(0.0f, 1.5f, 1.0f);
        pos2 = new Vector3(-1.0f, 1.5f, 1.0f);
        pos3 = new Vector3(1.0f, 1.5f, 1.0f);

        rot = Quaternion.identity;

        Instantiate(sine, pos1, rot);
        Instantiate(square, pos2, rot);
        Instantiate(triangle, pos3, rot);

       
     }

    public void instantiateCube()
    {
        if (!isCollided)
        {
            childObject = "Cube";
            angle = 360.0f / 12;
            radius = 1.0f;
            notename = new string[4] { "C", "D#", "E", "F#" };

            centerPos = GameObject.Find("OVRPlayerController").transform.position;
            addheight = new Vector3(0.0f, 1.0f, 0.0f);
            for (int i = 0; i < 4; i++)
            {
                Quaternion rotation = Quaternion.AngleAxis(i * angle, Vector3.up);

                Vector3 direction = rotation * Vector3.forward;
                Vector3 position = centerPos + addheight + (direction * radius);
                musicBox[i] = Instantiate(musicBox[i], position, rotation);
                //musicBox[i].name = notename[i];
                musicBox[i].transform.Find(childObject).name = notename[i];
            }
            isCollided = true;
        }

    }
    //public bool grabbedObject(GameObject grabbedObj)
    //{
    //  // grabbedObj = GameObject.Find(objectName);
    //   bool isDestroyed = false;
    //   Debug.Log("SPAWNOBJ GRABBED " + grabbedObj.name);

    //   switch (grabbedObj.name)
    //   {            
    //       case "sine_grab(Clone)":
    //           Destroy(GameObject.Find("square_grab(Clone)"));
    //           Destroy(GameObject.Find("triangle_grab(Clone)"));

    //           Destroy(GameObject.Find("sine_grab(Clone)"), 3f);

    //           isDestroyed = true;
    //           note.instantiateCube();
    //           break;
    //       case "square_grab(Clone)":
    //           Destroy(GameObject.Find("sine_grab(Clone)"));
    //           Destroy(GameObject.Find("triangle_grab(Clone)"));

    //           Destroy(GameObject.Find("square_grab(Clone)"), 3f);

    //           isDestroyed = true;
    //           note.instantiateCube();
    //           break;
    //       case "triangle_grab(Clone)":
    //           Destroy(GameObject.Find("square_grab(Clone)"));
    //           Destroy(GameObject.Find("sine_grab(Clone)"));

    //           Destroy(GameObject.Find("triangle_grab(Clone)"),3f);

    //           isDestroyed = true;
    //           note.instantiateCube();
    //           break;
    //       default:
    //           Debug.Log("Nothing Found, Error");
    //           //isDestroyed = true;
    //           break;
    //   }

    //   return isDestroyed;

    //}



    //// Update is called once per frame
    //void Update () {
    //    //if (gameObject.GetComponent<OVRGrabbable>() == true)
    //    //{
    //    //    checkGrabbedObject();
    //    //   // ovr.isGrabbed = false;
    //if(ovr.isGrabbed)
    //gameObject.name;
    //    //}

    //}

    // void Update()
    //{
    //    lr.SetPosition(0, transform.position);
    //    RaycastHit hit;
    //    if (Physics.Raycast(transform.position, transform.forward, out hit))
    //    {
    //        if (hit.collider)
    //        {
    //            lr.SetPosition(1, hit.point);
    //            if (hit.collider.tag == "LaserEnd")
    //            {
    //                lr.SetPosition(1, hit.point);
    //            }
    //        }
    //    }
    //    else
    //    {
    //        lr.SetPosition(1, transform.forward * 5000);
    //    }
    //}


}
