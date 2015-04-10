# UnityOSC
Open Sound Control (OSC) for Unity 

## Usage

* Add the "OSC.cs" script to a (empty) GameObject. 
** Configure its settings in the inspector. 	 	
* Create another script to receive OSC messages. In that script :
** Add a public OSC variable to point to the OSC instance you created in the previous step.
** Add a function with the following form : void OnReceive(OSCMessage message) {}
** Register that function on Start with SetAddressHandler( "/address" , OnReceive );
(to be continued)