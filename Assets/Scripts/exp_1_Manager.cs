using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class exp_1_Manager : MonoBehaviour {
    public FreqAmpModifier exp1;
    //public testCollider _test;
    public bool isTestInitiated, isFirstTestComplete;
    public int firstRandom;
	// Use this for initialization
	void Start () {
        firstRandom=0;
        isTestInitiated = false;
    }

    private int randomNumber()
    {
        
        int random = (int)Random.Range(1,13); // 1 to 12// 1 being C, 2 being C# and so on;
        return random;
    }

    public void compareNumber(int userPlayed)
    {
        //counter
        if (userPlayed == firstRandom)
        {
            Debug.Log("Firstrandom "+ firstRandom );
            Debug.Log("UserPlayed " + userPlayed);

            Debug.Log("Correct guess");
        }

    }
	// Update is called once per frame
	void Update () {
        if (OVRInput.Get(OVRInput.Button.SecondaryHandTrigger))
        {
            isTestInitiated = true;
            firstRandom = randomNumber();
            exp1.noteval(firstRandom);
        }


    }
}
