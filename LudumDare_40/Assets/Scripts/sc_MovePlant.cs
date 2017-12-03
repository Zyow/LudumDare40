using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sc_MovePlant : MonoBehaviour 
{

public float rotateAmount = 20f; // Amount to be rotated
private float itsLeft = -1 ;
 
// This will handle when a player enters the collider on the plant or grass object
void OnTriggerEnter(Collider other)
{

	Vector3 delta = gameObject.transform.InverseTransformPoint(other.gameObject.transform.position);
 	float xAbs = Mathf.Abs(delta.x);
	float yAbs = Mathf.Abs(delta.y);
 	float zAbs = Mathf.Abs(delta.z);
	if (xAbs > yAbs && xAbs > zAbs) 
	{
     // side is hit
		if (delta.x < 0)
		{
			itsLeft = -1;
		}
			// left
		else
		{
			itsLeft = 1;
		}
        // right
 	} 

	    // Check that the colliding object is the player object
    if (other.gameObject.tag == "Player")
	{
	    StartCoroutine(RotateMe(itsLeft * Vector3.forward * rotateAmount, 0.2f));
	}
	    // Call the rotation


}
 
// This will handle when the colliding object leaves the plant or grass bit
void OnTriggerExit(Collider other)
{
    // Check that the colliding object is the player object
    if (other.gameObject.tag == "Player")
	{
	    StartCoroutine(RotateMe(itsLeft * -Vector3.forward * rotateAmount, 0.2f));
		itsLeft = -1 ;
	}
    // Call the rotation
}
 
IEnumerator RotateMe(Vector3 byAngles, float inTime)
{
    Quaternion fromAngle = transform.rotation;
    Quaternion toAngle = Quaternion.Euler(transform.eulerAngles + byAngles);
	
   
    for (float t = 0; t < 1; t += Time.deltaTime/inTime)
    {
        transform.rotation = Quaternion.Lerp(fromAngle, toAngle, t);
        yield return null;
    }


}
 
}
