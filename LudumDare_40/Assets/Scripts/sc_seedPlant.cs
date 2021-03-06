﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sc_seedPlant : MonoBehaviour {


	public GameObject prefabSeed;
	public float checkRangeSeed = 2;
	private ParticleCollisionEvent[] collisionEvents = new ParticleCollisionEvent[16];
	private ParticleSystem partSyst;

	void Start()
	{
		partSyst = GetComponent<ParticleSystem>();
	}
	
 void OnParticleCollision(GameObject other) {
	 
	 //int safeLength = particleSystem.safeCollisionEventSize;
	  int safeLength = partSyst.GetSafeCollisionEventSize();

     if (collisionEvents.Length < safeLength)
         collisionEvents = new ParticleCollisionEvent[safeLength];

     int numCollisionEvents = partSyst.GetCollisionEvents(other, collisionEvents);

     int i = 0;

     while (i < numCollisionEvents) {
         Vector3 collisionHitLoc = collisionEvents[i].intersection;
		
		 if (other.tag == "canSeed")
		 {
			Instantiate(prefabSeed, collisionHitLoc, Quaternion.identity);
		 }

         i++;
     }
 }

}
