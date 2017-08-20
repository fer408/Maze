using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key : MonoBehaviour 
{
	//Create a reference to the KeyPoofPrefab and Door
	public GameObject keyPoofPrefab;
	public Door door;
	public AudioClip keyClip;
	public bool keyCollected = false;

	void Update()
	{
		//Not required, but for fun why not try adding a Key Floating Animation here :)
	}

	public void OnKeyClicked()
	{
		// Instatiate the KeyPoof Prefab where this key is located
		// Make sure the poof animates vertically
		Debug.Log ("You have the key!");
		GameObject keyPoofPrefabClone = (GameObject)Instantiate(keyPoofPrefab, transform.position, transform.rotation);
		keyPoofPrefab.GetComponent<AudioSource>().clip = keyClip;
		//gameObject.GetComponentInChildren<AudioSource>().Play();
		// Call the Unlock() method on the Door
		door.Unlock();
		// Set the Key Collected Variable to true
		keyCollected = true;
		// Destroy the key. Check the Unity documentation on how to use Destroy
		Destroy(gameObject);
	}

}