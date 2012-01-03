using UnityEngine;
using System.Collections;

public class TestMover : MonoBehaviour {
	
	public Transform t;
	
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	void OnMouseDown() {
		t.Translate(Vector3.up);
	}
}
