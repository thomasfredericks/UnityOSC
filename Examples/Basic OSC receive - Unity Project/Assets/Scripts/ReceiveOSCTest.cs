using UnityEngine;
using System.Collections;

public class ReceiveOSCTest : MonoBehaviour {

	public OSC osc;
	
	// Use this for initialization
	void Start () {
		osc.SetAddressHandler( "/level" , OnReceive );
	
	}

	// Function that receives the message
	void OnReceive(OscMessage message) {

		float data = message.GetFloat(0);

		print ( data );

		float normalized = Mathf.InverseLerp(-120,5,data); // Normalize

		float scale = Mathf.Lerp(0.1f,4f,normalized); // De normalize to new range

		transform.localScale = new Vector3(scale,scale,scale);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
	