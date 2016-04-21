using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class ThirdLevelController : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
    public void PlayButtonClick()
    {
        SceneManager.LoadScene("Level3");
    }
}
