using UnityEngine;
using System.Collections;

public class SendPositionOnOnMouseDown : MonoBehaviour {

		public OSC osc;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	  
	}


	void OnMouseDown() {
        OscMessage message;

        message = new OscMessage();
        message.address = "/OnMouseDownXYZ";
        message.values.Add(transform.position.x);
        message.values.Add(transform.position.y);
        message.values.Add(transform.position.z);
        osc.Send(message);

        message = new OscMessage();
        message.address = "/OnMouseDownX";
        message.values.Add(transform.position.x);
        osc.Send(message);

        message = new OscMessage();
        message.address = "/OnMouseDownY";
        message.values.Add(transform.position.y);
        osc.Send(message);

        message = new OscMessage();
        message.address = "/OnMouseDownZ";
        message.values.Add(transform.position.z);
        osc.Send(message);
    }
	
}
