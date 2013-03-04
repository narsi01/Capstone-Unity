using UnityEngine;
using System.Collections;
using System;
using System.Collections.Generic;


public class CameraAll : MonoBehaviour {

    public CameraSingle[] camerasList;
    //List<CameraSingle> camerasList; 
    //camerasList = new List<CameraSingle>();

    public void Awake()
    {
        //count number of Kinects
        //int number;
        //camerasList = new CameraSingle[number];

        //For each KinectSingle in KinectAll.kinectList {
            //Create new Camera object in Unity3D scene
            
            //Create new CameraSingle class (CameraSingle *current = new CameraSingle)
            //camerasList[i] = new CameraSingle();
            //This immediately calls CameraSingle.start() which grabs calibration data and sets the camera’s initial location

            //Attach the CameraSingle class to the Camera object

            //Link the KinectSingle class to CameraSingle class (current.kinectLink = KinectSingle)

            //Add the KinectSingle class to the CameraList
        //}

        //For each CameraSingle class, calls CameraSingle.action() 
    }
}

//new CameraSingle class
public class CameraSingle : MonoBehaviour {
    public float x, y, z;//(represent 3D coordinate)
    //private KinectSingle kinectLink;
	public void start(){
	    //Based on the calibration of the KinectSDK code, the Camera is calibrated and its 
        //initial location is set.
    }
	public void action(){//(continually updating)
	    //SemaphoreWait(kinectSDKsemaphore) //wait for data from KinectLink
	    //Calls getData()
	    //Calls setCam()
    }
	public void getData(){
	    //Grabs the x,y,z values from KinectLink
	    //Assigns them to our global x,y,z variables
    }
    public void setCam(){
        //Sets the Camera position in the scene based on the x,y,z values from getData()
    }
}

//old CameraSingle class
/*
public class CameraSingle : MonoBehaviour {
    public float horizontalSpeed = 2.0F;
    public float verticalSpeed = 2.0F;
    public float height, theta, distance, deg, initialDist, initalHeight;
    public int stop = 0;
    public new Vector3 minitial;
    System.IO.StreamReader file;
	// Use this for initialization
	void Start () {
        minitial = transform.position;
        initialDist = transform.position.z;
        initalHeight = transform.position.y;
       // mrot = transform.localEulerAngles;
        file = new System.IO.StreamReader(@"C:\Users\Kevin\Documents\New Unity Project\Assets\Data.txt");
        action();
        //mainCamera.rect = new Rect(0.0f, 0.0f, 0.5f, 1.0f);
	}

	// FixedUpdate is called 30 times a second
	void FixedUpdate () {
        if (stop == 0)
        {
            action();
            //transform.position = minitial;
        }
	}

    void readStdin()
    {
        //char[] delimiterChars = { ' ', ',', '.', ':', '\t' };
        string chars = " ,:\tabcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ!@#$%^&*()/?><";
        char[] delimiterChars = chars.ToCharArray();
        //char[] delimiterChars = { ' ', ',', '.', ':', '\t', 'a', 'b', 'c', 'd', 'e'};
        string line;
        //line = Console.ReadLine();
        line = file.ReadLine();
        if (String.IsNullOrEmpty(line))
        {
           // print("asdfasdf");
            stop = 1;
            return;
        }
        string[] words = line.Split(delimiterChars);
        foreach (string word in words)
        {
            print(word);
        }
        double x, y, z;
        double.TryParse(words[0], out x);
        double.TryParse(words[1], out y);
        double.TryParse(words[2], out z);
        //double x = Double.Parse(words[0]);
        //double y = Double.Parse(words[1]);
        //double z = Double.Parse(words[2]);
        height = tofloat(x);
        theta = tofloat(y);
        distance = tofloat(z);
        //deg = Single.Parse(words[3]);
    }

    void setCam()
    {
        transform.position = new Vector3(transform.position.x, initalHeight+height, initialDist + distance);
        transform.localEulerAngles = new Vector3(transform.localEulerAngles.x, 90.0f-theta, transform.localEulerAngles.z);
        //transform.Rotate(0.0f, transform.localEulerAngles.y - b, 0.0f);
    }
    void action()
    {
        readStdin();
        setCam();
    }

    float tofloat(double input)
    {
        float result = (float)input;
        if (float.IsPositiveInfinity(result))
        {
            result = float.MaxValue;
        }
        else if (float.IsNegativeInfinity(result))
        {
            result = float.MinValue;
        }
        return result;
    }
}
*/