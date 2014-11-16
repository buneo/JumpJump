using UnityEngine;
using System.Collections;

public class PlayFrog : MonoBehaviour {
	private int jumpLong = 500;
	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.Space)) {
			Jump();
				}
	}
	void Jump()
	{
		rigidbody.AddForce(new Vector3(0,jumpLong,0),ForceMode.Force);
	}
}