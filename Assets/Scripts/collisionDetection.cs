using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collisionDetection : MonoBehaviour
{

    public spawnObjects sp;
    public waveformModifier play;
    //private bool checkObj;
    private int x; //1. Sine 2. Square 3. Triangle
    // Use this for initialization
    void Start()
    {
        x = 0;
        sp = GameObject.Find("Scene").transform.GetComponent<spawnObjects>();
        //checkObj = false;
    }


    public void collisionManager(GameObject collidedObj)
    {
        switch (collidedObj.name)
        {
            case "sine_grab(Clone)":
                x = 1;

                Debug.Log("instantiating");

                Destroy(GameObject.Find("square_grab(Clone)"));
                Destroy(GameObject.Find("triangle_grab(Clone)"));
                Destroy(GameObject.Find("sine_grab(Clone)"));

                Debug.Log("YOU PICKED SINE WAVE");
                sp.instantiateCube();

                //initObj = true;

                break;
            case "square_grab(Clone)":
                x = 2;

                Destroy(GameObject.Find("sine_grab(Clone)"));
                Destroy(GameObject.Find("triangle_grab(Clone)"));
                Destroy(GameObject.Find("square_grab(Clone)"));

                Debug.Log("YOU PICKED SQUARE WAVE");
                sp.instantiateCube();

                // initObj = true;

                break;
            case "triangle_grab(Clone)":
                x = 3;
                Destroy(GameObject.Find("square_grab(Clone)"));
                Destroy(GameObject.Find("sine_grab(Clone)"));
                Destroy(GameObject.Find("triangle_grab(Clone)"));

                Debug.Log("YOU PICKED TRIANGLE WAVE");
                sp.instantiateCube();

                // initObj = true;

                break;

            case "C":
                Debug.Log("Value X: " + x);

                if (x == 1)
                {
                    play.playSineCNote();
                    Debug.Log("YOU PICKED SQUARE WAVE");
                }
                else if (x == 2)
                { play.playSquareCNote(); }
                else if (x == 3)
                { play.playTriangleCNote(); }
                break;
            case "D#":
                if (x == 1)
                { play.playSineDSharpNote(); }
                else if (x == 2)
                { play.playSquareDSharpNote(); }
                else if (x == 3)
                { play.playTriangleDSharpNote(); }
                break;
            case "E":
                if (x == 1)
                { play.playSineENote(); }
                else if (x == 2)
                { play.playSquareENote(); }
                else if (x == 3)
                { play.playTriangleENote(); }
                break;
            case "F#":
                if (x == 1)
                { play.playSineFSharpNote(); }
                else if (x == 2)
                { play.playSquareFSharpNote(); }
                else if (x == 3)
                { play.playTriangleFSharpNote(); }
                break;

            default:
                //x = 0;
                Debug.Log("Nothing");
                break;
        }

    }
}
