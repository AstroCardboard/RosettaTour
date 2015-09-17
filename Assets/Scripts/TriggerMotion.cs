// Script that turns on and off the rotational behavior of 67P
using UnityEngine;
using System.Collections;

public class TriggerMotion : MonoBehaviour {
	
	public GameObject target = null;
	public bool orbitY;
	public Cardboard cb;
	
	// Cardboard.CardboardTriggered = false;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (cb.Triggered) {
			if (orbitY == false) {
				orbitY = true;
			}
			else {
				orbitY = false;
			}
		}
		if (orbitY){
			transform.RotateAround(target.transform.position, Vector3.up, Time.deltaTime * 10);	
		}
	}
}
