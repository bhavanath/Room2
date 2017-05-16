using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tv : MonoBehaviour {

	public GameObject ttv;
	public GameObject screen;
	public GameObject ALLLight;
	public GameObject Lamp1;


	float timer = 0.0f;
	public float Seconds;
	private int rand;

	//private float minFlickerSpeed=0.8f;
	//private float maxFlickerSpeed=1.0f;

	void Start () 
	{
		
		ttv.SetActive(false);
		screen.SetActive (false);
		ALLLight.SetActive (false);


	}
	
	void Update () {

		rand = Random.Range (0, 2);
		Debug.Log (rand);


		timer += Time.deltaTime;
		Seconds = timer % 60;

		if (Seconds >= 20.0f) 
		{
			ttv.SetActive (true);
			screen.SetActive (true);
		} 

		if (Seconds >= 30.0f) 
		{
			
			ALLLight.SetActive (true);
		}

		if (Seconds >= 40.0) 
		{
			ttv.SetActive (false);
			screen.SetActive (false);
			if (rand == 1) {
				Lamp1.SetActive (true);
			} else if (rand == 0)
				Lamp1.SetActive (false);
		}

		
	}


}
