using UnityEngine;
using System.Collections;

public class DoorOpener : MonoBehaviour 
{

	private bool doorOpen = false;
	public GameObject OtherGameObject;
	private Light DoorLight;

	// Use this for initialization
	void Start () 
	{
		DoorLight = OtherGameObject.GetComponent<Light>();
		DoorLight.enabled = false;
	}
	
	// Update is called once per frame
	void Update () 
	{
	
	}

	void OnMouseDown ()
	{
		if (doorOpen == false)
		{
			transform.Rotate(Vector3.forward*30);
			DoorLight.enabled = true;
			doorOpen = true;
		}
		else
		{
			transform.Rotate(-Vector3.forward*30);
			DoorLight.enabled = false;
			doorOpen = false;
		}
	}
}
