using UnityEngine;
using System.Collections;

public class Ataque : MonoBehaviour 
{
	public Transform BulletPrefab;
	private float time_holding;
	//Vector3 posicion;

	// Use this for initialization
	void Start () 
	{
		time_holding = 0;
		//posicion = GetComponent<Transform> ().localPosition;
	}
	
	// Update is called once per frame
	void Update () 
	{
		verificar_disparo();
	}

	private void verificar_disparo()
	{
		if(Input.GetKeyDown("j"))
		{
			generarBala();
		}
		else if(Input.GetKey("j"))
		{
			hold();
			if(time_holding > 0.2f)
			{
				generarBala();
			}
		}
		else if(Input.GetKeyUp("j"))
		{
			unhold();
		}
	}

	private void hold()
	{
		time_holding += Time.deltaTime;
	}

	private void unhold()
	{
		time_holding = 0;
	}

	public void generarBala()
	{
		//posicion.Set (posicion.x+32, posicion.y, posicion.z);
		//Instantiate (BulletPrefab, posicion, Quaternion.identity);
		Instantiate (BulletPrefab, new Vector3(transform.position.x+2,transform.position.y,transform.position.z), Quaternion.identity);
	}
}
