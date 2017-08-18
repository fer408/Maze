﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key : MonoBehaviour 
{
    //Create a reference to the KeyPoofPrefab and Door
	public GameObject KeyPoofPrefab;
	public Door door;

	bool KeyCollected = false;
	void Update()
	{
		//Not required, but for fun why not try adding a Key Floating Animation here :)
	}

	public void OnKeyClicked()
	{
        // Instatiate the KeyPoof Prefab where this key is located
        // Make sure the poof animates vertically
        // Call the Unlock() method on the Door
        // Set the Key Collected Variable to true
        // Destroy the key. Check the Unity documentation on how to use Destroy
		GameObject keyPoofPrefabClone = Instantiate (KeyPoofPrefab, transform.position, Quaternion.Euler(90f,0f,0f));
		keyPoofPrefabClone.GetComponentInChildren<AudioSource>().Play();
		door.Unlock();
		KeyCollected = true;
		Destroy (gameObject);
    }

}
