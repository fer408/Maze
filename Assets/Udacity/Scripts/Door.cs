using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour 
{
	// Create a boolean value called "locked" that can be checked in OnDoorClicked() 
	// Create a boolean value called "opening" that can be checked in Update() 
	public bool doorIsClosed = true;
	private bool locked = true;
	private bool opening = false;
	public AudioClip[] doorClips;

	void Update() {
		// If the door is opening and it is not fully raised
		// Animate the door raising up
		if (opening && transform.position.y < 14f) {
			transform.Translate(0, 2.5f * Time.deltaTime, 0, Space.World);
			doorIsClosed = false;
		}
	}

	public void OnDoorClicked() {
		// If the door is clicked and unlocked
		// Set the "opening" boolean to true
		// (optionally) Else
		// Play a sound to indicate the door is locked
		if (!locked)
		{

			opening = true;

			gameObject.GetComponentInChildren<AudioSource>().clip = doorClips[1];
			gameObject.GetComponentInChildren<AudioSource>().Play();

			//remove the collider so that we can enter the temple
			gameObject.GetComponent<Collider>().enabled = false;

		}
		else
		{
			gameObject.GetComponentInChildren<AudioSource>().clip = doorClips[0];
			gameObject.GetComponentInChildren<AudioSource>().Play();

		}
	}

	public void Unlock()
	{
		// You'll need to set "locked" to false here
		locked = false;

	}
}