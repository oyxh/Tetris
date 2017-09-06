using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GUIManager : MonoBehaviour {

	// Use this for initialization
    float start_time;
    Text timer;
	void Start () {
        start_time = Time.time;
        timer = GameObject.Find("Canvas/Timer").GetComponent<Text>();
	}
	
	// Update is called once per frame
	void Update () {
        float addTime = Time.time - start_time;
        int minutes = (int)addTime / 60;
        int seconds = (int)addTime % 60;
        string strTime = string.Format("{0:00}:{1:00}",minutes,seconds);
        timer.text = strTime;
	}
}
