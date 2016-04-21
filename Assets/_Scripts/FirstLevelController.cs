using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class FirstLevelController : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
    public void PlayButtonClick()
    {
        SceneManager.LoadScene("main");
    }
    public void BackButtonClick()
    {
        SceneManager.LoadScene("menu");
    }
}
