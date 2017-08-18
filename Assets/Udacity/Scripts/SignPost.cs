using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class SignPost : MonoBehaviour
{	
	public void ResetScene(string stringName){
		Debug.Log ("You have clicked to restart the game");
		SceneManager.LoadScene (stringName);
	}
}