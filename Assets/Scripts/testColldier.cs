using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class testColldier : MonoBehaviour {

    public FreqAmpModifier freq;
    public sceneManager1 send;
    public int notenumber, noteVal;
    public bool isFirstValSent, isSecondValSent, isThirdValSent;


    void Start()
    {
        isFirstValSent = false; isSecondValSent = false; isThirdValSent = false;
        notenumber = 0;
        noteVal = 0;
    }
    public void noteCollision(string overLappedObject)
    {
        //overLappedObject = collidedObj.name;
        switch (overLappedObject)
        {
            case "C":
                Debug.Log("C note");
                freq.playCNote();
                notenumber = 1;
                send.compareNumber(notenumber);
                break;
            case "C#":
                Debug.Log("C# note");
                freq.playCSharpNote();
                notenumber = 2;
                send.compareNumber(notenumber);
                break;
            case "D":
                Debug.Log("D note");
                freq.playDNote();
                notenumber = 3;
                send.compareNumber(notenumber);
                break;
            case "D#":
                Debug.Log("D# note");
                freq.playDSharpNote();
                notenumber = 4;
                send.compareNumber(notenumber);
                break;
            case "E":
                Debug.Log("E note");
                freq.playENote();
                notenumber = 5;
                send.compareNumber(notenumber);
                break;
            case "F":
                Debug.Log("F note");
                freq.playFNote();
                notenumber = 6;
                send.compareNumber(notenumber);
                break;
            case "F#":
                Debug.Log("F# note");
                freq.playFSharpNote();
                notenumber = 7;
                send.compareNumber(notenumber);
                break;
            case "G":
                Debug.Log("G note");
                freq.playGNote();
                notenumber = 8;
                send.compareNumber(notenumber);
                break;
            case "G#":
                Debug.Log("G# note");
                freq.playGSharpNote();
                notenumber = 9;
                send.compareNumber(notenumber);
                break;
            case "A":
                Debug.Log("A note");
                freq.playANote();
                notenumber = 10;
                send.compareNumber(notenumber);
                break;
            case "A#":
                Debug.Log("A# note");
                freq.playASharpNote();
                notenumber = 11;
                send.compareNumber(notenumber);
                break;
            case "B":
                Debug.Log("B note");
                freq.playBNote();
                notenumber = 12;
                send.compareNumber(notenumber);
                break;
        }       
    }
     void Update()
     { // send on collision not on UPDATE!
     //   noteVal = notenumber;
     //   if (send.isTestInitiated)
     //   {
     //       if (send.compareNumber(noteVal) && !isFirstValSent)
     //       {
     //           Debug.Log("PLAYER PLAYED " + noteVal);
     //           Debug.Log("SAME VALUE") ;
     //           isFirstValSent = true;
     //       }
     //       if (send.compareNumber(noteVal) &&!isSecondValSent &&isFirstValSent)
     //       {
     //           Debug.Log("PLAYER PLAYED " + noteVal);
     //           Debug.Log("SAME VALUE");
     //           isSecondValSent = true;

     //       }
     //       if(send.compareNumber(noteVal) && isSecondValSent && !isThirdValSent)
     //       {
     //           Debug.Log("PLAYER PLAYED " + noteVal);
     //           Debug.Log("NOT SAME ");
     //           isThirdValSent = true;
     //       }
     //   }
     }
}
