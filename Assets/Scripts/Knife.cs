using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Knife : MonoBehaviour {

    private OVRGrabbable grabbableScript;

    private void Awake()
    {
        grabbableScript = GetComponent<OVRGrabbable>();
    }

    // Use this for initialization
    void Start () {
        GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeAll;
	}
	
	// Update is called once per frame
	void Update () {
        if (grabbableScript.isGrabbed) {
            GetComponent<Rigidbody>().constraints = RigidbodyConstraints.None;
        }
	}
}
