using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sc_IgnoreLayer : MonoBehaviour {

	// Use this for initialization
	void Start () {
		 Physics.IgnoreLayerCollision(0, 8, true);
	}
	
}
