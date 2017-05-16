using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tv : MonoBehaviour {

	public GameObject ttv;
	public GameObject screen;
	public GameObject ALLLight;
	public GameObject Lamp1lght;
	public GameObject Ghost;


	float timer = 0.0f;
	public float Seconds;
	private int rand;

	private bool StopFlickr=false;

	//private int minFlickerSpeed=0;
	//private int maxFlickerSpeed=5;

	void Start () 
	{
		
		ttv.SetActive(false);
		screen.SetActive (false);
		ALLLight.SetActive (false);
		Ghost.SetActive (false);


	}
	
	void FixedUpdate()
	{
		if (Seconds >= 50.0f) 
		{
			StopFlickr = true;
			Lamp1lght.SetActive (false);
			Ghost.SetActive (true);
		}
	}

	void Update () {

		rand = Random.Range (0, 2);
		Debug.Log (rand);

		timer += Time.deltaTime;
		Seconds = timer % 200;

		if (Seconds >= 20.0f) 
		{
			ttv.SetActive (true);
			screen.SetActive (true);
		} 

		if (Seconds >= 30.0f) 
		{
			ALLLight.SetActive (true);
		}

		if (Seconds > 40.0 && !StopFlickr) 
		{ 
			{
				if (rand == 1)
					Lamp1lght.SetActive (true);
				else if (rand == 0)
					Lamp1lght.SetActive (false);
			}
		}
		//if(Seconds > 50.0)

		
	}


}
