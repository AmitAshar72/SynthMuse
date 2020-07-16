using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class waveformModifier : MonoBehaviour {

    public LibPdInstance pdPatch;
    
    public Slider amplitude;
    float amp;
	// Use this for initialization
	void Start () {
        amp = 0.0f;
        
	}

    //C Note

    public void playSineCNote()
    {
        Debug.Log("SINE C");
        pdPatch.SendFloat("midi", 60);
        pdPatch.SendFloat("bang", amp);
    }

    public void playSquareCNote()
    {
        Debug.Log("SQUARE C");
        pdPatch.SendFloat("squareMidi", 60);
        pdPatch.SendFloat("squareBang", amp);
    }

    public void playTriangleCNote()
    {
        Debug.Log("TRIANGLE C");
        pdPatch.SendFloat("triangleMidi", 60);
        pdPatch.SendFloat("triangleBang", amp);
    }

    //D Sharp Note

    public void playSineDSharpNote()
    {
        Debug.Log("SINE D SHARP");
        pdPatch.SendFloat("midi", 63);
        pdPatch.SendFloat("bang", amp);
    }

    public void playSquareDSharpNote()
    {
        Debug.Log("SQUARE D SHARP");
        pdPatch.SendFloat("squareMidi", 63);
        pdPatch.SendFloat("squareBang", amp);
    }

    public void playTriangleDSharpNote()
    {
        Debug.Log("TRIANGLE D SHARP");
        pdPatch.SendFloat("triangleMidi", 63);
        pdPatch.SendFloat("triangleBang", amp);
    }
    
    //E Note

    public void playSineENote()
    {
        Debug.Log("SINE E");
        pdPatch.SendFloat("midi", 64);
        pdPatch.SendFloat("bang", amp);
    }

    public void playSquareENote()
    {
        Debug.Log("SQUARE E");
        pdPatch.SendFloat("squareMidi", 64);
        pdPatch.SendFloat("squareBang", amp);
    }

    public void playTriangleENote()
    {
        Debug.Log("TRIANGLE E");
        pdPatch.SendFloat("triangleMidi", 64);
        pdPatch.SendFloat("triangleBang", amp);
    }

    //F Sharp note

    public void playSineFSharpNote()
    {
        Debug.Log("SINE F SHARP");
        pdPatch.SendFloat("midi", 66);
        pdPatch.SendFloat("bang", amp);
    }

    public void playSquareFSharpNote()
    {
        Debug.Log("SQUARE F SHARP" );
        pdPatch.SendFloat("squareMidi", 66);
        pdPatch.SendFloat("squareBang", amp);
    }

    public void playTriangleFSharpNote()
    {
        Debug.Log("TRIANGLE F SHARP");
        pdPatch.SendFloat("triangleMidi", 66);
        pdPatch.SendFloat("triangleBang", amp);
    }



    // Update is called once per frame
    void Update () {
        amp = amplitude.value;
       
	}
}
