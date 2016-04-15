using UnityEngine;
using System.Collections;

public class PlayerFollow : MonoBehaviour {
    //Public instance variables
    public Transform target;
    public float speed;
    

    //private instance variables
    private Transform _transform;
    private int rotationSpeed = 3; //speed of turning
                           // Use this for initialization
    void Start () {
        this._transform = gameObject.GetComponent<Transform>();
	}
	
	// Update is called once per frame
	void Update () {
        float step = speed * Time.deltaTime;
        this._transform.position = Vector3.MoveTowards(this._transform.position, target.position,step);

        //rotate to look at the player
        _transform.rotation = Quaternion.Slerp(_transform.rotation,
        Quaternion.LookRotation(target.position - _transform.position), rotationSpeed * Time.deltaTime);
    }
}
