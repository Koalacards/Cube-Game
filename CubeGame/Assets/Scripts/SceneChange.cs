using UnityEngine;
using System.Collections;

public class SceneChange : MonoBehaviour {

	public void ChangeLevel(string sceneToChangeTo)
    {
        Application.LoadLevel(sceneToChangeTo);
    }

}
