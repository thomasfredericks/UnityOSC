using UnityEngine;
using System.Collections;

public class ReceiveFFT : MonoBehaviour {

	public OSC oscReference;
	
	// Use this for initialization
	void Start () {
		oscReference.SetAddressHandler( "/fft" , OnReceive );
		
	}
	
	// Function that receives the message
	void OnReceive(OscMessage message) {

		for ( int i = 0 ; i < transform.childCount ; i++) {

			float data = message.GetFloat(i);

			float scaled = Mathf.Lerp(0.1f,4f,data); // Scale to new range

			Transform childTransform = transform.GetChild(i);
			childTransform.localScale = new Vector3(scaled,0.1f,0.1f);
		}
		

	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
