using UnityEngine;
using System.Collections;

public class SendPositionByOSC : MonoBehaviour {

	public OSC osc;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	  OscMessage message = new OscMessage();
        message.address = "/Update";
        message.values.Add(transform.position.x);
        message.values.Add(transform.position.y);
        message.values.Add(transform.position.z);
        osc.Send(message);
	}


}
