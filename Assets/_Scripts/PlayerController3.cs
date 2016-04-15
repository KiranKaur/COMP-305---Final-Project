using UnityEngine;
using System.Collections;

public class PlayerController3 : MonoBehaviour
{

    //public instance variables
    public GameController3 gameController;
    public Transform groundCheck;

    //private instance variables
    private Transform _transform;
    private AudioSource[] _audioSources;
    private AudioSource _jumpSound;
    private AudioSource _keySound;
    private AudioSource _hurtSound;
    private bool isMine;

    // Use this for initialization
    void Start()
    {
        InvokeRepeating("TimeCount", 1.0f, 1.0f);
        this._transform = gameObject.GetComponent<Transform>();

        this._audioSources = gameObject.GetComponents<AudioSource>();
        this._keySound = this._audioSources[1];
        this._hurtSound = this._audioSources[3];
    }

    // Update is called once per frame
    void Update()
    {
        
       
    }

   //to keep track of time 
    void TimeCount() {
        this.gameController.LivesValue -= 1;
        if (this.gameController.LivesValue < 1)
        {
            this.gameController._endGame();
        }
    }

    void FixedUpdate()
    {
        this.isMine = Physics2D.Linecast(
            this._transform.position,
            this.groundCheck.position,
            1 << LayerMask.NameToLayer("Mines"));
        Debug.DrawLine(this._transform.position, this.groundCheck.position);

        if (this.isMine)
        {
            Debug.Log("mines");
        }

    }
    //mehod to detect collision between objects
    void OnCollisionEnter(Collision col)
    {
        Debug.Log("outer");
        if (col.gameObject.CompareTag("Power"))
        {
            //Debug.Log("mine");
            Destroy(col.gameObject);
            this._keySound.Play();
            this.gameController.KeyValue += 1;
            this.gameController.LivesValue+=50;
        }
        if (col.gameObject.CompareTag("Enemy"))
        {
            this.gameController.LivesValue--;

            this._hurtSound.Play();
            this._resetPlayer();

        }
        if (col.gameObject.CompareTag("Hospital"))
        {
           // if (this.gameController.KeyValue == 5)
          //  {
           //     Destroy(col.gameObject);

                //  Debug.Log("Collision");
                this.gameController._winGame();
           // }
            Debug.Log("Collision gate");
        }


    }

    //private methods
    private void _resetPlayer()
    {
        this._transform.position = new Vector3(17f, 48f, 490f);

    }
}
