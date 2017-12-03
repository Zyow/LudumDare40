using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sc_SortingLayer : MonoBehaviour {
  
	public string sortingLayerName;        // The name of the sorting layer .
    public int sortingOrder;            //The sorting order
     
     void Start ()
     {
		 var rend = GetComponent<Renderer>();
         
		 // Set the sorting layer and order.
         rend.sortingLayerName = sortingLayerName;
         rend.sortingOrder=sortingOrder;
     }
}
