using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FreqAmpModifier : MonoBehaviour
{
    // The Pd patch we'll be communicating with.
    public LibPdInstance pdPatch;
    // public DeplyCubes note;
    private GameObject x;
    public Slider Slider;
    public Slider Frequency;
    public Slider Index;

    public Slider CNote;
    public Slider CSharpNote;
    public Slider DNote;
    public Slider DSharpNote;
    public Slider ENote;
    public Slider FNote;
    public Slider FSharpNote;
    public Slider GNote;
    public Slider GSharpNote;
    public Slider ANote;
    public Slider ASharpNote;
    public Slider BNote;


    float c_midiVal = 0.0f; float c_sharp_midiVal = 0.0f;   float d_midiVal = 0.0f; float d_sharp_midiVal = 0.0f;
    float e_midiVal = 0.0f; float f_midiVal = 0.0f;  float f_sharp_midiVal = 0.0f; float g_midiVal = 0.0f;
    float g_sharp_midiVal = 0.0f; float a_midiVal = 0.0f; float a_sharp_midiVal = 0.0f; float b_midiVal = 0.0f;
    float amp = 0.0f;
    float freq = 0.0f;
    float ind = 0.0f;

    private void Start()
    {
        CNote = GameObject.Find("C_Note").transform.GetComponent<Slider>();
        CSharpNote = GameObject.Find("CSharp_Note").transform.GetComponent<Slider>();
        DNote = GameObject.Find("D_Note").transform.GetComponent<Slider>();
        ENote = GameObject.Find("E_Note").transform.GetComponent<Slider>();
        DSharpNote = GameObject.Find("DSharp_Note").transform.GetComponent<Slider>();
        FNote = GameObject.Find("F_Note").transform.GetComponent<Slider>();
        FSharpNote = GameObject.Find("FSharp_Note").transform.GetComponent<Slider>();
        GNote = GameObject.Find("G_Note").transform.GetComponent<Slider>();
        GSharpNote = GameObject.Find("GSharp_Note").transform.GetComponent<Slider>();
        ANote = GameObject.Find("A_Note").transform.GetComponent<Slider>();
        ASharpNote = GameObject.Find("ASharp_Note").transform.GetComponent<Slider>();
        BNote = GameObject.Find("B_Note").transform.GetComponent<Slider>();
    }

    public void noteval(int note)
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
        pdPatch.SendFloat("midi", c_midiVal);
        pdPatch.SendFloat("bang", amp);
    }


    public void playCSharpNote()
    {
        pdPatch.SendFloat("midi", c_sharp_midiVal);
        pdPatch.SendFloat("bang", amp);
    }

    public void playDNote()
    {
        pdPatch.SendFloat("midi", d_midiVal);
        pdPatch.SendFloat("bang", amp);
    }

    public void playDSharpNote()
    {
        pdPatch.SendFloat("midi", d_sharp_midiVal);
        pdPatch.SendFloat("bang", amp);
    }

    public void playENote()
    {
        pdPatch.SendFloat("midi", e_midiVal);
        pdPatch.SendFloat("bang", amp);
    }

    public void playFNote()
    {
        pdPatch.SendFloat("midi", f_midiVal);
        pdPatch.SendFloat("bang", amp);
    }

    public void playFSharpNote()
    {
        pdPatch.SendFloat("midi", f_sharp_midiVal);
        pdPatch.SendFloat("bang", amp);
    }

    public void playGNote()
    {
        pdPatch.SendFloat("midi", g_midiVal);
        pdPatch.SendFloat("bang", amp);
    }

    public void playGSharpNote()
    {
        pdPatch.SendFloat("midi", g_sharp_midiVal);
        pdPatch.SendFloat("bang", amp);
    }

    public void playANote()
    {
        pdPatch.SendFloat("midi", a_midiVal);
        pdPatch.SendFloat("bang", amp);
    }

    public void playASharpNote()
    {
        pdPatch.SendFloat("midi", a_sharp_midiVal);
        pdPatch.SendFloat("bang", amp);
    }

    public void playBNote()
    {
        pdPatch.SendFloat("midi", b_midiVal);
        pdPatch.SendFloat("bang", amp);
    }

    //private void OnTriggerEnter(Collider other)
    //{
    //    pdPatch.SendFloat("midi", c_midiVal);
    //    pdPatch.SendFloat("bang", amp);
    //}
    //void dNote()
    //{
    //    pdPatch.SendBang("start");
    //    pdPatch.SendFloat("midi", 42);
    //    pdPatch.SendBang("stop");
    //}
    // Update is called once per frame
    void Update()
    {
        c_midiVal = (CNote.value+1)*12;
        c_sharp_midiVal = ((CSharpNote.value+1)*12) + 1;

        d_midiVal = ((DNote.value+1)*12)+2;
        d_sharp_midiVal =((DSharpNote.value + 1) * 12) + 3;

        e_midiVal = ((ENote.value + 1) * 12) + 4;

        f_midiVal = ((FNote.value + 1) * 12) + 5;
        f_sharp_midiVal = ((FSharpNote.value + 1) * 12) + 6;

        g_midiVal = ((GNote.value + 1) * 12) +7;
        g_sharp_midiVal = ((GSharpNote.value + 1) * 12) + 8;

        a_midiVal = ((ANote.value + 1) * 12) + 9;
        a_sharp_midiVal = ((ASharpNote.value + 1) * 12) + 10;

        b_midiVal = ((BNote.value + 1) * 12) + 11;

        amp = Slider.value;
        freq = Frequency.value;
        ind = Index.value;
        if (amp < 0.0f)
            amp = 0.0f;

        if (freq < 0.0f)
            freq = 0.0f;

        if (ind < 0.0f)
            ind = 0.0f;

    //    pdPatch.SendFloat("vol", amp);       
        pdPatch.SendFloat("freq", freq);
        pdPatch.SendFloat("index", ind);

    }
}
