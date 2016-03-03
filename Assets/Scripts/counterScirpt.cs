using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class counterScirpt : MonoBehaviour {
    private float singleRealGameTime;
    private float singleDisplayedGameTime;
    public GameObject textScoreGameObject;
    public Text scoreText;
    public GameObject lostTextGameObject;
    public GameObject winTextGameObject;
    public GameObject whatToDoTextGameObject;
    public static bool hasPlayerWon;
    private float waitTillscoreScreen;
    private bool usedNextInvoke;
    // Use this for initialization
	void Start () {
        usedNextInvoke = false;
        waitTillscoreScreen = 3;
        hasPlayerWon = false;
        scoreText = textScoreGameObject.GetComponent<Text>();
        singleRealGameTime = 12;
        singleDisplayedGameTime = 10;
	}
	
	// Update is called once per frame
	void Update () {
        singleRealGameTime -= Time.deltaTime;
        singleDisplayedGameTime = singleRealGameTime;
        if (singleRealGameTime > 10)
        {
            singleDisplayedGameTime = 10;
            whatToDoTextGameObject.SetActive(true);
        }
        else {
            whatToDoTextGameObject.SetActive(false);
        }

        if (singleRealGameTime <= 0||hasPlayerWon) {
            singleDisplayedGameTime = 0;
            
            if (hasPlayerWon) //player won
            {
                winTextGameObject.SetActive(true);
                playerwon();
            }
            else //player lost
            {
                lostTextGameObject.SetActive(true);
                playerlost();
            }
        }
        scoreText.text = ((int)singleDisplayedGameTime).ToString();
        
    }

    private void playerwon() {
        waitTillscoreScreen -= Time.deltaTime;
        if (waitTillscoreScreen <= 0&&usedNextInvoke==false)
        {
            usedNextInvoke = true;
            countscript.StartAdvance();
        }
    }
    private void playerlost()
    {
        waitTillscoreScreen -= Time.deltaTime;
        if (waitTillscoreScreen <= 0 && usedNextInvoke == false)
        {
            usedNextInvoke = true;
            countscript.StartRestart();
        }
    }
}
