using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class RestartGame : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if (controls.spacePressed) {

                //Application.LoadLevel(0);>
                SceneManager.LoadScene("Menu");

        }
	}
}
