using UnityEngine;
using System.Collections;
/*
Author: Jagpreet Jattana
Last Modified: MArch-24-2016


*/
public class EnemyController1 : MonoBehaviour {

    // PRIVATE INSTANCE VARIABLES
    private Transform _transform;
    private Vector3 _currentPosition;
    private int flip = 1;


    // Used this for initialization
    void Start()
    {
        this._transform = gameObject.GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        //this makes enemies move up and down
        this._currentPosition = this._transform.position;
        if ((this._transform.position.y < 12)&&(flip==1))
        {
            this._currentPosition += new Vector3(0, 0.05f, 0);
        }
        else
        {
            flip = 0;
        }
        

        if ((this._transform.position.y>1.5)&&(flip==0)) {
            this._currentPosition -= new Vector3(0, 0.05f, 0);
        }
        else
        {
            flip = 1;
        }
        this._transform.position = this._currentPosition;

    }



    //public methods
    public void _restart()
    {
        this._transform.position = new Vector3(11f, 2f, -2f);

    }
}
