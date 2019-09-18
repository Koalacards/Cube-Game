using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class CoroutineScript : MonoBehaviour {

	
	void Start () {
				StartCoroutine (JumpToScene());
	}
	
		IEnumerator JumpToScene(){
				yield return new WaitForSeconds (6f);
				SceneManager.LoadScene ("MainScene");
		}



	
	void Update () {
	
	}
}
