using UnityEngine;
using System.Collections;

public class ObjectMover : MonoBehaviour 
{

	private bool objectClosed = true;
	public float upDistance = 30;
	public float sideDistance = 0;
	public float forthDistance = 0;

	void Awake ()
	{

	}

	// Use this for initialization
	void Start () 
	{

	}
	
	// Update is called once per frame
	void Update () 
	{

	}

	void OnMouseDown ()
	{
		if (objectClosed)
		{
			transform.Translate(Vector3.down*upDistance);
			transform.Translate(Vector3.right*sideDistance);
			transform.Translate(Vector3.forward*forthDistance);
			objectClosed = false;
		}
		else
		{
			transform.Translate(-Vector3.down*upDistance);
			transform.Translate(-Vector3.right*sideDistance);
			transform.Translate(-Vector3.forward*forthDistance);
			objectClosed = true;
		}
	}
}
