using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class szansSkript : MonoBehaviour {
    public int bazacount;
    public Text bazaText;
    public GameObject szansa1;
    public GameObject szansa2;
    public GameObject szansa3;
    public GameObject MultiSceneGO;

	// Use this for initialization
	void OnEnable () {
        bazacount = countscript.baza;
        bazaText.text ="Baza "+ bazacount.ToString();
        //Debug.Log(countscript.life);
        if (countscript.life >= 1) {
            if (bazacount==9) {
                SceneManager.LoadScene("Ending", LoadSceneMode.Single);
                Destroy(MultiSceneGO);
            }
            szansa1.SetActive(true);
            if (countscript.life >= 2)
            {
                szansa2.SetActive(true);
                if (countscript.life == 3)
                {
                    szansa3.SetActive(true);
                }
                else {
                    szansa3.SetActive(false);
                }
            }
            else
            {
                szansa2.SetActive(false);
            }
        }
        else
        {
            szansa1.SetActive(false);
            SceneManager.LoadScene("Fail", LoadSceneMode.Single);
            //MultiSceneGO.SetActive(false);
            Destroy(MultiSceneGO);
        }

    }
	
	// Update is called once per frame
	void Update () {
	    
	}
}
