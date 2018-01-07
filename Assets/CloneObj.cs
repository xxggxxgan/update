using System.Collections.Generic;  
using UnityEngine;  

public class CloneObj : MonoBehaviour {  

	public GameObject spritePre;    //预制体  
	public Rigidbody Bullet;
	GameObject cloneObj;    //克隆出的对象  
	public  Transform  FPonit;

	// Use this for initialization  
	void Start () {  


		cloneObj = Instantiate(spritePre) as GameObject;      
		cloneObj.transform.parent = transform;  
		//cloneObj.transform.localPosition = new Vector3((i % 5-2) * 100, (i / 5) * 100, 0);  
			//5s后销毁对象  
		Destroy(cloneObj, 3); 
		  
	}
	void Update () {
		if(Input.GetKeyDown(KeyCode.J)){
			cloneObj = Instantiate(spritePre) as GameObject;      
			Destroy (cloneObj, 1);
		}
	}
}