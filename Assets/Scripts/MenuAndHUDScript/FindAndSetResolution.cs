﻿using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;

public class FindAndSetResolution : MonoBehaviour {
    private Dropdown dropDown;
	// Use this for initialization
	void Start () {
        dropDown = GameObject.Find("Dropdown").GetComponent<Dropdown>();
        List<string> listOption = new List<string>();
        Resolution[] resolutions = Screen.resolutions;
		string currentRes = Screen.currentResolution.width + "x" + Screen.currentResolution.height;
		int resPosition = 0;
		int i = 0;
        foreach (Resolution res in resolutions) {
            string resString = res.width + "x" + res.height;
			listOption.Add(resString);
			if (resString == currentRes) {
				resPosition = i;
			}
			i++;
        }
        /*
        listOption.Add("1920x1080");
        listOption.Add("1920x1080");
        listOption.Add("1920x1080");
        listOption.Add("1920x1080");*/
        
        dropDown.AddOptions(listOption);
		dropDown.value = resPosition;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
    
    
    public void ChangeResolution(int num) {
        Resolution[] resolutions = Screen.resolutions;
        if (num < resolutions.Length) {
            Screen.SetResolution(resolutions[num].width, resolutions[num].height, true);            
        }
    }
}
