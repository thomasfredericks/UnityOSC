using UnityEngine;
using System.Collections;

public class ReceiveCubeCByOSC : MonoBehaviour {
    
   	public OSC osc;


	// Use this for initialization
	void Start () {
	   osc.SetAddressHandler( "/CubeC" , OnReceive );
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnReceive(OscMessage message){
		float x = message.GetFloat(0);
         float y = message.GetFloat(1);
		float z = message.GetFloat(2);

		transform.position = new Vector3(x,y,z);
	}
}
