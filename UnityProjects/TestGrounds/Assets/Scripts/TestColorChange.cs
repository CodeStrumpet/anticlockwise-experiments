using UnityEngine;
using System.Collections;

public class TestColorChange : MonoBehaviour {
	
	public MeshRenderer meshRenderer;
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
		
	}
	
	
	
	void OnMouseEnter() {
		renderer.material.color = Color.red;
		
		meshRenderer.material.color = Color.yellow;
	}
}
