using UnityEngine;
using System.Collections;

public class Movement : MonoBehaviour 
{
	public GameObject IronMan;
	public float rSpeed;

	void Update()
	{

		OrbitAround ();
	}
	public void OrbitAround()
	{
		transform.RotateAround (IronMan.transform.position,Vector3.up, rSpeed*Time.deltaTime);

	}
}