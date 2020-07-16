using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class inputHandler : MonoBehaviour {

    public LibPdInstance pdPatch;
    public collisionCheckLever lever;
    public timerClass3 T;
    public float freqVal, indexVal;
    public bool isTestInitiated, isFirstTestComplete, isSecondTestComplete, isThirdTestComplete, isEqual, callTest1, callTest2, callTest3;
    private float[] frequency;
    private float[] index;
    private int[] order = new int[3];
    // Use this for initialization
    private void Start() {
        freqVal = 1.0f;  indexVal = 0.0f;
        callTest1 = false; callTest2 = false; callTest3 = false;
        isTestInitiated = false; isFirstTestComplete = false; isSecondTestComplete = false; isThirdTestComplete = false;
        frequency = new float[3] { 250.0f, 283.0f, 300.0f};
        index = new float[3] { 30.0f, 25.0f, 2.0f };
        generateOrder();
    }
    //order in which the test sound be played
    private void generateOrder()
    {
        for (int i = 0; i < 3; i++)
        {
            order[i] = (int)Random.Range(0, 3);
            Debug.Log("order #" + i + " :" + order[i]);
        }
    }
    //frequency
    public void rotatePosFreq()
    {
        if (freqVal < 250.0f)
            freqVal = 250.000000f;
        else if (freqVal >= 300.0f)
            freqVal = 300.0000000f;
        else if(freqVal>=250.0f || freqVal <300.0f)
        {
            GameObject.Find("Frequency Lever(Clone)").transform.Rotate(1.0f, 0.0f, 0.0f, Space.World);
            freqVal = ((freqVal * 100) / 100.0f) + 0.20f;
        }                
    }
    public void rotateNegFreq()
    {
        if (freqVal <= 250.0f)
            freqVal = 250.0000000f;
        else if (freqVal >300.0f)
            freqVal = 300.0000000f;
        else if(freqVal <=300.0f || freqVal >250.0f) {
            GameObject.Find("Frequency Lever(Clone)").transform.Rotate(-1.0f, 0.0f, 0.0f, Space.World);
            freqVal = ((freqVal * 100) / 100.0f)- 0.20f;
        }      
        
    }
    //index
    void rotatePosInd()
    {
        if (indexVal < 0.0f)
            indexVal = 0.0f;
        else if (indexVal > 30.0f)
            indexVal = 30.0f;
        else if (indexVal > 0.0f || indexVal <30.0f)
        {
            GameObject.Find("Index Lever(Clone)").transform.Rotate(1.0f, 0.0f, 0.0f, Space.World);
            indexVal = ((indexVal * 100) / 100.0f)+0.2f;
        }

    }
    void rotateNegInd()
    {
        if (indexVal < 0.0f)
            indexVal = 0.0f;
        else if (indexVal > 30.0f)
            indexVal = 30.0f;
        else if (indexVal > 0.0f || indexVal < 30.0f)
        {
            GameObject.Find("Index Lever(Clone)").transform.Rotate(-1.0f, 0.0f, 0.0f, Space.World);
            indexVal = ((indexVal * 100) / 100.0f) - 0.2f;
        }
    }

    public void playC()
    {
        //freqVal = (freqVal * 100) / 100;
        //indexVal = (indexVal * 100) / 100;
        pdPatch.SendFloat("midi", 60);
        pdPatch.SendFloat("bang", 0.5f);
        pdPatch.SendFloat("freq", freqVal);
        Debug.Log("FREQVAL:" + freqVal);
        pdPatch.SendFloat("index", indexVal);
        Debug.Log("INDVAL: " + indexVal);

        //ch

        if (isTestInitiated)
        {
            if (!isFirstTestComplete)
            {
                if ( freqVal == frequency[order[0]] && indexVal == index[order[0]])
                {
                    Debug.Log("RIGHT GUESS");
                    isFirstTestComplete = true;
                    //stop timer1
                    T.stoptimer();
                }
                if (freqVal == frequency[order[0]])
                { //prompt on screen
                }
                if (indexVal == index[order[0]])
                {
                    //prompt on screen
                }
                //{ Debug.Log("WRONG GUESS, TRY AGAIN"); }
            }
            if (isFirstTestComplete && !isSecondTestComplete)
            {
                if (freqVal == frequency[order[1]] && indexVal == index[order[1]])
                {
                    Debug.Log("RIGHT GUESS");
                    isSecondTestComplete = true;

                    //stop timer 2
                    T.stoptimer();
                }
                if (freqVal == frequency[order[1]])
                { //prompt on screen
                }
                if (indexVal == index[order[1]])
                {
                    //prompt on screen
                }
                //else
                //{ Debug.Log("WRONG GUESS, TRY AGAIN"); }
            }
            if (isSecondTestComplete && !isThirdTestComplete)
            {
                if (freqVal == frequency[order[2]] && indexVal == index[order[2]])
                {
                    Debug.Log("RIGHT GUESS");
                    isThirdTestComplete = true;

                    T.stoptimer();
                    //stop timer 3
                    //level complete prompt and fade out to scene2
                }
                if (freqVal == frequency[order[2]])
                { //prompt on screen
                }
                if (indexVal == index[order[2]])
                {
                    //prompt on screen
                }
                //else
                //{ Debug.Log("WRONG GUESS, TRY AGAIN"); }
            }
            
        }
    }
    public void playrandom(float f, float ind)
    {
        pdPatch.SendFloat("midi", 60);
        pdPatch.SendFloat("bang", 0.5f);
        pdPatch.SendFloat("freq", f);       
        pdPatch.SendFloat("index", ind);
    }

   

    // Update is called once per frame
    void Update () {
        if (OVRInput.Get(OVRInput.Button.One) && lever.isFreqLeverAttached )
        { rotateNegFreq(); }
        if (OVRInput.Get(OVRInput.Button.Two) && lever.isFreqLeverAttached)
        { rotatePosFreq(); }
        
        if (OVRInput.Get(OVRInput.Button.Three)&& lever.isIndLeverAttached)
        { rotateNegInd(); }
        if (OVRInput.Get(OVRInput.Button.Four)&& lever.isIndLeverAttached)
        { rotatePosInd(); }

       // if (OVRInput.Get(OVRInput.Button.PrimaryIndexTrigger)) 
            //begin test, set levers to identity quaternion // plays sound
        if (OVRInput.Get(OVRInput.Button.SecondaryIndexTrigger)) //&& lever.isFreqLeverAttached && lever.isIndLeverAttached)
            playC();


        if (OVRInput.GetDown(OVRInput.Button.PrimaryIndexTrigger) && !isFirstTestComplete)
        {
            isTestInitiated = true;
            if (!callTest1)
            { //start timer1
                T.starttimer();
                callTest1 = true;
            }
            playrandom(frequency[order[0]],index[order[0]]);
        }
        if (OVRInput.GetDown(OVRInput.Button.PrimaryIndexTrigger) && isTestInitiated && isFirstTestComplete && !isSecondTestComplete)
        {
            if (!callTest2)
            {
                //time delay
                T.starttimer();
                //start timer2
                callTest2 = true;
            }
            playrandom(frequency[order[1]], index[order[1]]);
        }
        if (OVRInput.GetDown(OVRInput.Button.PrimaryIndexTrigger) && isTestInitiated && !isThirdTestComplete && isSecondTestComplete)
        {
            if (!callTest3)
            {
                //time delay
                T.starttimer();
                //start timer 3
                callTest3 = true;
            }
            playrandom(frequency[order[2]], index[order[2]]);
        }



    }
}
