using UnityEngine;
using System.Collections;

public class SendOSC : MonoBehaviour {


	public OSC oscReference;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	  OscMessage message = new OscMessage();
        message.address = "/test";
        message.values.Add(transform.position.x);
        message.values.Add(transform.position.y);
        message.values.Add(transform.position.z);
        oscReference.Send(message);
	}

	void OnMouseDown() {
        OscMessage message = new OscMessage();
        message.address = "/test";
        message.values.Add(transform.position.x);
        message.values.Add(transform.position.y);
        message.values.Add(transform.position.z);
        oscReference.Send(message);
	}
}
