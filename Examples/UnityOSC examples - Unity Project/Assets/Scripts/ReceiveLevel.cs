using UnityEngine;
using System.Collections;

public class ReceiveLevel : MonoBehaviour {

	public OSC oscReference;
	
	// Use this for initialization
	void Start () {
		oscReference.SetAddressHandler( "/level" , OnReceive );
	
	}

	// Function that receives the message
	void OnReceive(OscMessage message) {

		float data = message.GetFloat(0);

		float scaled = Mathf.Lerp(0.1f,8f,data); // Scale to new range

		transform.localScale = new Vector3(scaled,scaled,scaled);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
	