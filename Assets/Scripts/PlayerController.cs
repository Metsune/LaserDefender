using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

	public float playerSpeed;
	public Transform transform;

	// Use this for initialization
	void Start () {
	 Debug.Log ("Test");
	}
	
	// Update is called once per frame
	void Update () {

		PlayerMovement ();

	}

	void PlayerMovement () 
	{

		Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
		transform.rotation = Quaternion.LookRotation(Vector3.forward, mousePos - transform.position);
    
		if (Input.GetKey(KeyCode.W)){
			transform.Translate(Vector2.up * playerSpeed * Time.deltaTime);
		}

		if (Input.GetKey(KeyCode.S)){
			transform.Translate(Vector2.down * playerSpeed * Time.deltaTime);
		}

	}

	void PlayerAttack () 
	{



	}
}