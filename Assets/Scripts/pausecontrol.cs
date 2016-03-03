using UnityEngine;
using System.Collections;

public class pausecontrol : MonoBehaviour {
	private bool isPaused;
    public GameObject pauseMenu;
    void Awake()
    {
        isPaused = false;

    }
	void Update () {
        if (controls.pausePressed)
        {
            ZAWARUDO();
        }
    }

    IEnumerator diosStand() {
        while (true)
        {
            if (Input.GetKeyDown(KeyCode.P) || Input.GetKeyDown(KeyCode.Escape))
            {
                ZAWARUDO();
                yield return null;
            }
        }
    }

    private void ZAWARUDO() {
        if (isPaused)//mudada
        {
            pauseMenu.SetActive(false); //toki wa ugokidasu
            Time.timeScale = 1;
            isPaused = false;
            CancelInvoke("okurwaDiabel");
        }
        else//shinei Kakyoin
        {
            pauseMenu.SetActive(true); //toki yo tomare
            Time.timeScale = 0;
            isPaused = true;
            Invoke("okurwaDiabel", 0.1f);
        }

    }
    void okurwaDiabel() {
        StartCoroutine(diosStand());
    }
}
