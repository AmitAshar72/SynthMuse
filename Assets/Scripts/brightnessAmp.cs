using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class brightnessAmp : MonoBehaviour {

    public LibPdInstance pdPatch;
    public Slider amp;
    public Slider brightness;
    public float ampVal, brightnessVal, finalAmp, finalBrightness;
	// Use this for initialization
	void Start () {
        ampVal = 0.4f; brightnessVal = 0.5f; finalAmp = 0.0f; finalBrightness = 0.0f;
        amp = GameObject.Find("amp").transform.GetComponent<Slider>();
        brightness = GameObject.Find("Brightness").transform.GetComponent<Slider>();
    }
    private void brightnessLevel()
    {
        //brightnessVal = brightness.value;
        RenderSettings.ambientLight = new Color(brightnessVal,brightnessVal,brightnessVal,1.0f);
    }
    public void fetchVal(float prevAmp, float prevBright)
    {
        finalAmp = prevAmp;
        finalBrightness = prevBright;

    }
	// Update is called once per frame
	void Update () {
        ampVal = amp.value;
        brightnessVal = brightness.value;
        brightnessLevel();
        if (OVRInput.GetDown(OVRInput.Button.PrimaryIndexTrigger))
        {
            playNote((int)Random.Range(1, 13));
            //sendBang
        }
        if (OVRInput.GetDown(OVRInput.Button.SecondaryIndexTrigger))
        {
            fetchVal(ampVal, brightnessVal);
            //load next scene, Save values 
        }
    }

    public void playNote(int note)
    {
        switch (note)
        {
            case 1:
                playCNote();
                break;
            case 2:
                playCSharpNote();
                break;
            case 3:
                playDNote();
                break;
            case 4:
                playDSharpNote();
                break;
            case 5:
                playENote();
                break;
            case 6:
                playFNote();
                break;
            case 7:
                playFSharpNote();
                break;
            case 8:
                playGNote();
                break;
            case 9:
                playGSharpNote();
                break;
            case 10:
                playANote();
                break;
            case 11:
                playASharpNote();
                break;
            case 12:
                playBNote();
                break;

            default:
                Debug.Log("Invalid");
                break;
        }
    }
    public void playCNote()
    {
        pdPatch.SendFloat("midi", 60);
        pdPatch.SendFloat("bang", ampVal);
    }


    public void playCSharpNote()
    {
        pdPatch.SendFloat("midi", 61);
        pdPatch.SendFloat("bang", ampVal);
    }

    public void playDNote()
    {
        pdPatch.SendFloat("midi", 62);
        pdPatch.SendFloat("bang", ampVal);
    }

    public void playDSharpNote()
    {
        pdPatch.SendFloat("midi", 63);
        pdPatch.SendFloat("bang", ampVal);
    }

    public void playENote()
    {
        pdPatch.SendFloat("midi", 64);
        pdPatch.SendFloat("bang", ampVal);
    }

    public void playFNote()
    {
        pdPatch.SendFloat("midi", 65);
        pdPatch.SendFloat("bang", ampVal);
    }

    public void playFSharpNote()
    {
        pdPatch.SendFloat("midi", 66);
        pdPatch.SendFloat("bang", ampVal);
    }

    public void playGNote()
    {
        pdPatch.SendFloat("midi", 67);
        pdPatch.SendFloat("bang", ampVal);
    }

    public void playGSharpNote()
    {
        pdPatch.SendFloat("midi", 68);
        pdPatch.SendFloat("bang", ampVal);
    }

    public void playANote()
    {
        pdPatch.SendFloat("midi", 69);
        pdPatch.SendFloat("bang", ampVal);
    }

    public void playASharpNote()
    {
        pdPatch.SendFloat("midi", 70);
        pdPatch.SendFloat("bang", ampVal);
    }

    public void playBNote()
    {
        pdPatch.SendFloat("midi", 71);
        pdPatch.SendFloat("bang", ampVal);
    }

}
