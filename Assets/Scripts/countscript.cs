using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
public class countscript : MonoBehaviour {
    public static int life;
    public static float time;
    public string[] sceneNameList;
    public static int sceneToNumber;
    public float timeToNextScene;
    private static float timeToNextSceneCounter;
    private static bool goNextScene;
    private static bool goRestartScene;
    public static int baza;
    public GameObject szansPanel;
    private static int currbaza;
    private static int currScene;
    void Awake() {
        sceneToNumber = 0;
        baza = 1;
        time = 0;
        life = 3;
    }
    void Update() {
        UpdateAdvanceToNextScene();
        UpdateRestartScene();
    }
    public static void StartAdvance() {
        timeToNextSceneCounter = 0;
        goNextScene = true;
    }
    private void UpdateAdvanceToNextScene() {
        if (goNextScene) {
            timeToNextSceneCounter += Time.deltaTime;
            if (szansPanel.activeInHierarchy == false) {
                szansPanel.SetActive(true);
            }
            //Debug.Log("wygryw" + baza);
            //Debug.Log(timeToNextSceneCounter);
            if (timeToNextScene < timeToNextSceneCounter) {
                
                SceneManager.LoadScene(sceneNameList[sceneToNumber], LoadSceneMode.Single);
                szansPanel.SetActive(false);
                currbaza = baza;
                currScene = sceneToNumber;
                baza++;
                sceneToNumber++;
                goNextScene = false;
            }
        }
    }
    public static void StartRestart()
    {
        baza= currbaza;
        sceneToNumber=currScene;

        life--;
        //here goes some loose factor or something
        timeToNextSceneCounter = 0;
        goRestartScene = true;
        
    }
    private void UpdateRestartScene()
    {
        
        if (goRestartScene)
        {
            timeToNextSceneCounter += Time.deltaTime;
            if (szansPanel.activeInHierarchy == false)
            {
                szansPanel.SetActive(true);
            }

            //Debug.Log("przegryw"+baza);
            //Debug.Log(timeToNextSceneCounter);
            if (timeToNextScene < timeToNextSceneCounter&&life>0)
            {
                SceneManager.LoadScene(sceneNameList[sceneToNumber], LoadSceneMode.Single);
                szansPanel.SetActive(false);
                currbaza = baza;
                currScene = sceneToNumber;
                baza++;
                sceneToNumber++;
                goRestartScene = false;
            }
        }
    }
}
