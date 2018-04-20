using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class init : MonoBehaviour {

	// Use this for initialization
	void Start () {
        GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeAll;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
