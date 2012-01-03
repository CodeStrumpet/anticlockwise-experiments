using UnityEngine;
using System.Collections;

public class MoveMyBuddy : MonoBehaviour {
	
	public Transform buddyTransform;
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
		
	}
	
	
	
	void OnMouseEnter() {
		renderer.material.color = Color.red;
		
		buddyTransform.renderer.material.color = Color.yellow;
	}
}
