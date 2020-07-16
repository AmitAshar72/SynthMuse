using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DeplyCubes : MonoBehaviour {
   
    public GameObject[] musicBox = new GameObject[12];
    public GameObject[] canvas = new GameObject[12];
    private string[] noteName, sliderName;
    string childObject = "Cube";
    //string chObj = "Slider";
    //string Text = "Text";
    //private float angle, radius;
    private Vector3 centerPos, canvasPos;
    // Use this for initialization
    void Start () {
        float angle = 360.0f / 12;
        float radius = 1.0f;
        float rad2 = 2.5f;
        centerPos = new Vector3(0.0f, 1.0f , 0.0f);
        canvasPos = new Vector3(0.0f, 1.5f, 0.0f);
        noteName = new string[12] { "C", "C#", "D", "D#", "E", "F", "F#", "G", "G#", "A", "A#", "B" };
        sliderName = new string[12] { "C_Note", "CSharp_Note", "D_Note", "DSharp_Note", "E_Note", "F_Note", "FSharp_Note", "G_Note", "GSharp_Note",
             "A_Note", "ASharp_Note", "B_Note" };
        for (int i = 0; i < 12; i++)
        {                    

            Quaternion rotation = Quaternion.AngleAxis(i * angle, Vector3.up);
            
            //Quaternion rotation2 = Quaternion.AngleAxis(-90.0f, Vector3.right);
            Vector3 direction = rotation * Vector3.forward;
            Vector3 position = centerPos + (direction * radius);
            Vector3 position2 = canvasPos + (direction * rad2);

            musicBox[i] = Instantiate(musicBox[i], position, rotation);            
            musicBox[i].transform.Find(childObject).name = noteName[i];

            //canvas[i] = Instantiate(canvas[i], position2, (rotation * rotation2));
            canvas[i] = Instantiate(canvas[i], position2, rotation);
            canvas[i].name = noteName[i];
            canvas[i].transform.GetChild(0).name = sliderName[i];
            canvas[i].transform.GetChild(1).GetComponent<Text>().text = noteName[i];
           
        }
       
    }




    //void InstantiateCircle()
    //{
        
    //    for (int i = 0; i < pieceCount; i++)
    //    {
            

            
    //        Instantiate(prefab, position, rotation);
    //    }
    //}





    }
