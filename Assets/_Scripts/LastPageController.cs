using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class LastPageController : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
    public void BackButtonClick()
    {
        SceneManager.LoadScene("menu");
    }
}
