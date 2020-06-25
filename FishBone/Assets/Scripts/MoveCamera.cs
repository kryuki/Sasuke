using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCamera : MonoBehaviour {
    //速度調整用変数
    public float speed;

    private Rigidbody rb;

	// Use this for initialization
	void Start () {
        //Rigidbodyを取得
        rb = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void FixedUpdate() {
        float moveX = Input.GetAxis("Horizontal");
        float moveY = 0f;
        float moveZ = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveX, moveY, moveZ);

        rb.AddForce(movement * speed);
    }
}
