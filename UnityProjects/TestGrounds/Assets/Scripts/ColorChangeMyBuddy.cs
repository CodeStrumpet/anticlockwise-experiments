using UnityEngine;
using System.Collections;

public class ColorChangeMyBuddy : MonoBehaviour {
	
	public MeshRenderer mr;
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
		
	}
	
	
	
	void OnMouseEnter() {
		renderer.material.color = Color.red;
		
		mr.material.color = Color.yellow;
	}
}
