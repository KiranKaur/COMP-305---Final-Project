using UnityEngine;
using System.Collections;
/*
Author: Jagpreet Jattana
Last Modified: MArch-24-2016


*/
public class PlayerController : MonoBehaviour {

    //public instance variables
    public GameController gameController;

    //private instance variables
    private Transform _transform;
    private AudioSource[] _audioSources;
    private AudioSource _jumpSound;
    private AudioSource _keySound;
    private AudioSource _hurtSound;

    // Use this for initialization
    void Start () {
        this._transform = gameObject.GetComponent<Transform>();

        this._audioSources = gameObject.GetComponents<AudioSource>();
        this._keySound = this._audioSources[1];
        this._hurtSound = this._audioSources[3];
    }
	
	// Update is called once per frame
	void Update () {
       

    }


    //mehod to detect collision between objects
    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.CompareTag("Key"))
        {
            
            Destroy(col.gameObject);
            this._keySound.Play();
            this.gameController.KeyValue += 1;
        }
        if (col.gameObject.CompareTag("Enemy"))
        {
            this.gameController.LivesValue--;
            
            this._hurtSound.Play();
            this._resetPlayer();

        }
        if (col.gameObject.CompareTag("Gate"))
        {
            if (this.gameController.KeyValue == 5) {
                Destroy(col.gameObject);
              
                Debug.Log("Collision");
                this.gameController._winGame();
            }
            Debug.Log("Collision gate");
        }

       
    }

    //private methods
    private void _resetPlayer() {
        this._transform.position = new Vector3(-23f, 15f, 24f);

    }
}
