using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Text;
using System.IO;
using System;

public class P_log : MonoBehaviour
{
  
public Transform playerObject;

    // Start is called before the first frame update
    void Start()
    {}

    // Update is called once per frame
    void Update()
    {

//Position:P
    	float P_X=playerObject.position.x;
    	float P_Y=playerObject.position.y;
    	float P_Z=playerObject.position.z;

//Rotation:R
    	float R_X=playerObject.rotation.eulerAngles.x;
		float R_Y=playerObject.rotation.eulerAngles.y;
		float R_Z=playerObject.rotation.eulerAngles.z;

// showing in consule : 
		Debug.Log(R_X);

//logging data in CSV File
		string path="P&RLog.txt";
		CSV_Write(P_X,P_Y,P_Z,R_X,R_Y,R_Z,path);



        

    }

void CSV_Write(float P_X,float P_Y,float P_Z,float R_X,float R_Y,float R_Z,string path)
{

using(System.IO.StreamWriter file= new System.IO.StreamWriter(@path,true)){
	file.WriteLine(P_X+","+P_Y+","+P_Z+","+R_X+","+R_Y+","+R_Z);

}

}
 

}