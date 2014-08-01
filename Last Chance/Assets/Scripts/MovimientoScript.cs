using UnityEngine;
using System.Collections;

public class MovimientoScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKey("d"))
		{
			rigidbody2D.velocity = new Vector2(5,0);
		}
		if(Input.GetKey("space"))
		{
			rigidbody2D.velocity = new Vector2(0,5);
		}
		if(Input.GetKey("s"))
		{
			rigidbody2D.velocity = new Vector2(0,-5);
		}
		if(Input.GetKey("a"))
		{
			rigidbody2D.velocity = new Vector2(-5,0);

		}
		if (Input.GetKeyUp ("d") || Input.GetKeyUp ("a")) {
			rigidbody2D.velocity=new Vector2(0,0);
		}
		if (Input.GetKey ("d") && Input.GetKey ("space")) {
			rigidbody2D.velocity=new Vector2(5,5);
		}
		if (Input.GetKey ("a") && Input.GetKey ("space")) {
			rigidbody2D.velocity=new Vector2(-5,5);
		}

	}
}
