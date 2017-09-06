using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class groups : MonoBehaviour {
    float lastFall;
	// Use this for initialization
	void Start () {
         lastFall = Time.time;
	}
	
	// Update is called once per frame
	void Update () {
        //向左移动
		if(Input.GetKeyDown(KeyCode.LeftArrow))
        {
            transform.position += new Vector3(-1, 0, 0);
        }
        //向右移动
        else if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            transform.position += new Vector3(1, 0, 0);
        }

        //旋转
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            transform.Rotate(0,0,-90);
        }
        //向左移动
        if (Input.GetKeyDown(KeyCode.DownArrow) || Time.time-lastFall>1)
        {
            transform.position += new Vector3(0, -1, 0);
            lastFall = Time.time;
        }
	}
}
