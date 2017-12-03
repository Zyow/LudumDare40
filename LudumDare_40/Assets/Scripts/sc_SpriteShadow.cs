using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sc_SpriteShadow : MonoBehaviour {

	void Start()
	{
		GetComponent<Renderer>().shadowCastingMode =  UnityEngine.Rendering.ShadowCastingMode.On;
		GetComponent<Renderer>().receiveShadows = true;

	}
}
