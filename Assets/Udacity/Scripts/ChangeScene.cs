using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour {

	public void GoToScene(string stringName){
		Debug.Log ("You have clicked to restart the game");
		SceneManager.LoadScene (stringName);
	}
}
