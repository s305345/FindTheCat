using UnityEngine;
using System.Collections;

public class ProjectedToScreen : MonoBehaviour {

	public GameObject ScreenGameObject;
	public GameObject LightGameObject;
	private bool LittleLight;
	private bool BigScreen;

	// Use this for initialization
	void Start () 
	{
		LightGameObject.SetActive(true);
		LittleLight = true;
		ScreenGameObject.SetActive(true);
		BigScreen = true;
	}
	
	// Update is called once per frame
	void Update () 
	{

	}

	void OnMouseDown ()
	{
		if (BigScreen == true)
		{
			ScreenGameObject.SetActive(false);
			LightGameObject.SetActive(false);
			BigScreen = false;
			LittleLight = true;
		}
		else
		{
			ScreenGameObject.SetActive(true);
			LightGameObject.SetActive(true);
			BigScreen = true;
			LittleLight = true;
		}
	}
}
