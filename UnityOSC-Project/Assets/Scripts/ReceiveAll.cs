using UnityEngine;
using System.Collections;

public class ReceiveAll : MonoBehaviour {

	public OSC oscReference;


	public GameObject noisinessGameObject;
	public GameObject brightnessGameObject;

	// Use this for initialization
	void Start () {
		oscReference.SetAllMessageHandler(OnReceive);
	}

	void OnReceive(OscMessage message){
		if ( message.address == "/noisiness" ) {

			float data = message.GetFloat(0);
			float scaled = Mathf.Lerp(0.1f,4f,data); // Scale to new range

			noisinessGameObject.transform.localScale = new Vector3(scaled,scaled,scaled);

		} else if ( message.address == "/brightness" ) {

			float data = message.GetFloat(0);
			Color c = new Color( data , data , data);
			
			brightnessGameObject.GetComponent<Renderer>().material.color = c;

		}
	}


	// Update is called once per frame
	void Update () {
	
	}
}
