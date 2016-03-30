using UnityEngine;
using System.Collections;

public class Present : MonoBehaviour {

	private int current = 0;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void Next (Material mat) {
		if (++current >= 5)
			current = 0;

		string file = "slides" + current.ToString ("D2") + "Tex";
		mat.mainTexture = Resources.Load (file) as Texture;
	}
}
