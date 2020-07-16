using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sceneManager1 : MonoBehaviour {
    
    public FreqAmpModifier exp1;
    public timerClass T;
    //public testCollider _test;
    public bool isTestInitiated, isFirstTestComplete, isSecondTestComplete, isThirdTestComplete, isEqual, callTest1, callTest2, callTest3;
    public int firstRandom, noteSequenceCounter, receivedInt;
    private int[] randomnos;
    // Use this for initialization
    void Start()
    {
        randomnos = new int[3];
        firstRandom = 0;
        receivedInt = 0;
        noteSequenceCounter = 0; //counter, while comparing random numbers
        callTest1 = false; callTest2 = false; callTest3 = false;
        isTestInitiated = false; isFirstTestComplete = false; isSecondTestComplete = false; isThirdTestComplete = false;
        isEqual = false;
        randomNumber();
    }

    private void randomNumber()
    {
        for (int i = 0; i < 3; i++)
        {
            randomnos[i] = (int)Random.Range(1, 13);
            Debug.Log("Random #" + i + " :" + randomnos[i]);
        }  // 1 to 12// 1 being C, 2 being C# and so on;
                
    }

    
    //void testInit()
    //{
    //    isTestInitiated = true;
    //    while (isTestInitiated)
    //    {
    //        if (!isFirstTestComplete && !callTest1)
    //        {
    //            test1();
    //            callTest1 = true;
    //        }
    //        if (isFirstTestComplete && !isSecondTestComplete &&!callTest2)
    //        { //delay
    //            test2();
    //            callTest2 = true;
    //        }
    //        if (isSecondTestComplete && !isThirdTestComplete && !callTest3)
    //        {  //delay 
    //            test3();
    //            callTest3 = true;
    //            isTestInitiated = false;
    //        }
    //    }
    //}
    //void test1()
    //{
    //    //start timer1
    //    Debug.Log("Rand: " + randomnos[0]);
    //    exp1.noteval(randomnos[0]);
    //}
    //void test2()
    //{        
    //        // Start timer 2
    //        //delay 5 secs // counter on the screen
    //        // play second sound
    //        exp1.noteval(randomnos[1]);
    //}
    //void test3()
    //{       
    //        //Start timer 3
    //        exp1.noteval(randomnos[2]);
       
    //}


   

    public void compareNumber(int val)
    {
        receivedInt = val;
        if (isTestInitiated && receivedInt!=0)
        {
            if (!isFirstTestComplete)
            {
                if (receivedInt == randomnos[0])
                {
                    Debug.Log("RIGHT GUESS");
                    isFirstTestComplete = true;
                    receivedInt = 0;
                    //stop timer1
                    T.stoptimer();
                }
                else
                { Debug.Log("WRONG GUESS, TRY AGAIN"); }
            }
            if (isFirstTestComplete && !isSecondTestComplete)
            {
                if (receivedInt == randomnos[1])
                {
                    Debug.Log("RIGHT GUESS");
                    isSecondTestComplete = true;
                    receivedInt = 0;
                    //stop timer 2
                    T.stoptimer();
                }
                else
                { Debug.Log("WRONG GUESS, TRY AGAIN"); }
            }
            if (isSecondTestComplete && !isThirdTestComplete)
            {
                if (receivedInt == randomnos[2])
                {
                    Debug.Log("RIGHT GUESS");
                    isThirdTestComplete = true;
                    receivedInt = 0;
                    T.stoptimer();
                    //stop timer 3
                    //level complete prompt and fade out to scene2
                }
                else
                { Debug.Log("WRONG GUESS, TRY AGAIN"); }
            }
        }


        //Debug.Log("USERPLAYED " + userPlayed);
        ////counter
        //if (userPlayed == randomnos[0])
        //{  //stop timer1
        //    Debug.Log("Firstrandom " + randomnos[0]);
        //    Debug.Log("UserPlayed " + userPlayed);
        //    Debug.Log("Correct guess"); // print on screen.

        //    isFirstTestComplete = true;
        //    return true;
        //}
        //if (userPlayed == randomnos[1] && isFirstTestComplete)
        //{
        //    Debug.Log("Secondrandom " + randomnos[1]);
        //    Debug.Log("UserPlayed " + userPlayed);
        //    Debug.Log("Correct guess"); // print on screen.
        //    isSecondTestComplete = true;
        //    return true;
        //}
        //if (userPlayed == randomnos[2] && isSecondTestComplete)
        //{
        //    Debug.Log("Thirdrandom " + randomnos[2]);
        //    Debug.Log("UserPlayed " + userPlayed);
        //    Debug.Log("Correct guess"); // print on screen.
        //    isThirdTestComplete = true;
        //    return true;
        //}
        //return isEqual;

    }
    // Update is called once per frame
    void Update()
    {
        if (OVRInput.GetDown(OVRInput.Button.SecondaryIndexTrigger) && !isFirstTestComplete )
        {
            isTestInitiated = true;
            if (!callTest1)
            { //start timer1
                T.starttimer();
                callTest1 = true;
            } 
            exp1.noteval(randomnos[0]);
            receivedInt = 0; // clearing older values
        }
        if (OVRInput.GetDown(OVRInput.Button.SecondaryIndexTrigger) && isTestInitiated && isFirstTestComplete && !isSecondTestComplete)
        {           
            if (!callTest2)
            {
                //time delay
                T.starttimer();
                //start timer2
                callTest2 = true;
            }           
            exp1.noteval(randomnos[1]);           
            receivedInt = 0; // clearing older values
        }
        if (OVRInput.GetDown(OVRInput.Button.SecondaryIndexTrigger) && isTestInitiated && !isThirdTestComplete && isSecondTestComplete)
        {
            if (!callTest3)
            {
                //time delay
                T.starttimer();
                //start timer 3
                callTest3 = true;
            }
            exp1.noteval(randomnos[2]);            
            receivedInt = 0; // clearing older values
        }

    }

}



