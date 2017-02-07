using UnityEngine;
using System.Collections;

public class Instantiator : MonoBehaviour {

	public GameObject prefab;



	
	// Use this for initialization
	void Start () {
		
		float nombreInstances = 25;

				
		for ( int i =0; i < nombreInstances ; i++ ) {
			Quaternion rotation = Quaternion.Euler(0,0,90);
			float iNormalized = Mathf.InverseLerp(0,nombreInstances,i);
			float x = Mathf.Lerp(-4,4,iNormalized);
			Vector3 position = new Vector3(x,0,0);
			GameObject instance = Instantiate( prefab , position , rotation ) as GameObject;
			instance.transform.parent = this.transform;
			
		}
		
		
	}
	
	// Update is called once per frame
	void Update () {
		
		
		
		
		
		
		
	}
}
