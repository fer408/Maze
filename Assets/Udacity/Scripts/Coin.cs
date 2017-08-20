using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour 
{
    //Create a reference to the CoinPoofPrefab
	public GameObject CoinPoofPrefab;

	public AudioClip coinClip;

    public void OnCoinClicked() {
        // Instantiate the CoinPoof Prefab where this coin is located
        // Make sure the poof animates vertically
        // Destroy this coin. Check the Unity documentation on how to use Destroy
		Instantiate (CoinPoofPrefab, transform.position, Quaternion.Euler(90f,0f,0f));
		CoinPoofPrefab.GetComponent<AudioSource>().clip = coinClip;
		Destroy (gameObject);


    }

}                 