using UnityEngine;
using System.Collections;

public class CatController : MonoBehaviour 
{
	public Transform[] destinations;
	private float previousPlace;
	private int newPlace;
	private Light spotted;
	public GameObject otherGameObject;

	// Use this for initialization
	void Start () 
	{
		transform.localPosition = new Vector3(188,-1,-506);
		previousPlace = 0;
		spotted = otherGameObject.GetComponent<Light>();
		spotted.enabled = false;
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (Input.GetKey("escape"))
			Application.Quit();
	}

	void OnMouseDown ()
	{
		StartCoroutine(LightFound());
	}

	IEnumerator LightFound ()
	{
		spotted.enabled = true;
		yield return new WaitForSeconds(2f);
		spotted.enabled = false;

		while (previousPlace == newPlace)
		{
			newPlace = Random.Range(0,destinations.Length);
		}
		transform.localPosition = destinations[newPlace].position;
		previousPlace = newPlace;
	}
}
