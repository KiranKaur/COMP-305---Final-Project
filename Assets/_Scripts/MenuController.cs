﻿using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour {

	// Use this for initialization
  
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
    public void StartButtonClick()
    {
        SceneManager.LoadScene("Instructions1");
    }
    public void InstructionButtonClick()
    {
        SceneManager.LoadScene("Instruction");
    }
    public void BackButtonClick()
    {
        SceneManager.LoadScene("menu");
    }
    public void QuitButtonClick()
    {
        Application.Quit();
    }
}
