using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateBone : MonoBehaviour {

    public float rotateSpeed = 10;  //ボーンの回転速度

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        transform.Rotate(new Vector3(0, 3, 0), rotateSpeed * Time.deltaTime);
	}
}
