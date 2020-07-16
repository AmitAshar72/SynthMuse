using System.Collections;
using System.Diagnostics;
using System.Collections.Generic;
using UnityEngine;
using Debug = UnityEngine.Debug;
using System.IO;

public class timerClass3 : MonoBehaviour
{

    public Stopwatch timer;
    private string path;
    private int counter;
    //private long time;
    private long totTime;
    // Use this for initialization
    void Start()
    {
       // time = 0;
        totTime = 0; counter = 0;
        path = @"E:\PureData\PD_VR_Project-master\Assets\Resources\test3.txt";
        timer = new Stopwatch();
    }

    public void starttimer()
    {
        totTime = 0;
        timer.Start();
    }
    public void stoptimer()
    {
        timer.Stop();
        totTime = timer.ElapsedMilliseconds;
        Debug.Log("TIME STOPPED at: " + totTime);
        timeToFile();
        timer.Reset();
    }
    public void timeToFile()
    {
        counter++;
        if (File.Exists(path))
        {
            using (var tw = new StreamWriter(path, true))
            {
                tw.WriteLine("TIME FOR #" + counter + " :" + totTime);
                tw.Close();
            }

        }
        else { Debug.Log("Error"); }

    }

    // Update is called once per frame
    void Update()
    {
        //time = timer.ElapsedMilliseconds;
        //Debug.Log("Time: " + time);
    }
}
