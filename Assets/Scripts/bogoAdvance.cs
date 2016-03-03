using UnityEngine;
using System.Collections;

public class bogoAdvance : MonoBehaviour {
    public GameObject disableThisIfGameStarts;
    public GameObject womanCamera;
    public GameObject manCamera;
    private int spacepressed;
	// Use this for initialization
	void Start () {
        
    }
	
	// Update is called once per frame
	void Update () {
        if (controls.spacePressed){
            spacepressed++;
        }
        if (spacepressed == 1) {
            showChick();
        }
        if (spacepressed == 2)
        {
            showGuy();
        }
        if (spacepressed == 3)
        {
            startGame();
        }
    }

    void showChick() {
        womanCamera.SetActive(true);
        manCamera.SetActive(false);
    }
    void showGuy() {
        manCamera.SetActive(true);
        womanCamera.SetActive(false);
    }
    void startGame() {
        manCamera.SetActive(false);
        womanCamera.SetActive(false);
        countscript.StartAdvance();
    }
}
