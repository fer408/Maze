using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour 
{
    // Create a boolean value called "locked" that can be checked in OnDoorClicked() 
	public bool locked = true;
    // Create a boolean value called "opening" that can be checked in Update() 
	public bool opening = false;
	public bool raised = true;
	public Door door;

    void Update() {
        // If the door is opening and it is not fully raised
            // Animate the door raising up
		if ((door == opening) && (raised = false)){
			transform.Rotate (0, 65, 0, Space.World);
		}
    }

    public void OnDoorClicked() {
        // If the door is clicked and unlocked
		if ((door) && (locked == false)) {
			opening = true;
		} else {
			door.GetComponentInChildren<AudioSource>().Play();
		}
            // Set the "opening" boolean to true
        // (optionally) Else
            // Play a sound to indicate the door is locked
    }

    public void Unlock()
    {
        // You'll need to set "locked" to false here
		locked = false;
    }
}
