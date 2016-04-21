using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
/*
Author: Jagpreet Jattana
Last Modified: MArch-24-2016


*/
public class GameController : MonoBehaviour {

    //private instance variables
    private int _keyValue;         
    private int _livesValue;

    
     

    //public instance variables

    public Text livesLabel;
    public Text scoreLabel;
    public Text gameOverLabel;

   
    public Text WinGameLabel;
    public Button restartButton;

   

    //getters and setters
    public int KeyValue
    {
        get
        {
            return _keyValue;
        }

        set
        {
            _keyValue = value;
            this.scoreLabel.text = "Keys: "+this._keyValue;
        }
    }

    public int LivesValue
    {
        get
        {
            return _livesValue;
        }

        set
        {
            _livesValue = value;
            if (this._livesValue <= 0) {
                this._endGame();
                }
            
            else {
                this.livesLabel.text = "Lives: " + this._livesValue;
            }
            
        }
    }
    // Use this for initialization
    void Start () {
        this._initialize();
       

	
	}
	
    // Update is called once per frame
	void Update () {
	
	}

    //private  methods
    private void _initialize() {
        this.KeyValue = 0;
        this.LivesValue = 5;
        this.gameOverLabel.enabled = false;
        this.WinGameLabel.gameObject.SetActive(false);
        this.restartButton.gameObject.SetActive(false);
    

    }
    //private methods
    //method to end game
    private void _endGame() {
       
        this.gameOverLabel.enabled = true;
      
        this.restartButton.gameObject.SetActive(true);
        this.livesLabel.enabled = false;
        this.scoreLabel.enabled = false;
   

    }
    // public methods
    //this method will execute when game objective is achieved
    public void _winGame()
    {
       
        this.livesLabel.gameObject.SetActive(false);
        this.WinGameLabel.gameObject.SetActive(true);
        this.scoreLabel.gameObject.SetActive(false);
       // this.restartButton.gameObject.SetActive(true);
        // Application.LoadLevel("Level1");
        SceneManager.LoadScene("Instructions2");

    }

    //method to restart the game
    public void RestarButtonClicked() {
        //Application.LoadLevel("Main");
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
