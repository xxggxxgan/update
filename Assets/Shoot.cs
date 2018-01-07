using System.Collections;

using UnityEngine;

public class Shoot : MonoBehaviour {
	int speed = 20;
	public  Rigidbody Bullet;

	public  Transform  FPonit;

	public 	Rigidbody  Player;
	// Use this for initialization
	void Start () {
		Player = GetComponent<Rigidbody> ();
	}

	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown(KeyCode.J)){
			Rigidbody clone;
			clone = (Rigidbody)Instantiate (Bullet, FPonit.position, FPonit.rotation);
			clone.velocity = transform.TransformDirection (Vector3.forward * 50);
		}
	}

	void Destroy(){
		


	}


}