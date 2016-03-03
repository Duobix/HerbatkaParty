using UnityEngine;
using System.Collections;

public class colaController : MonoBehaviour {
    public Vector3 movementR;
    public GameObject winParticles;
    public Vector3 posL;
    public Vector3 posR;
    public float turbo;
    private int shakes;
    [SerializeField]
    private int shakeBoomBottle;
    private Vector3 movementL;
    private Rigidbody rb;
    private float timeLeft;
    private bool datTemp;
	void Awake () {
        datTemp = false;
        timeLeft = 1;
        
    }
	
	// Update is called once per frame
	void Update () {
        if (controls.leftPressed){
            this.transform.position = posL;
            shakes++;
        }
        if (controls.rightPressed)
        {
            this.transform.position = posR;
            shakes++;
        }

       
            timeLeft -= Time.deltaTime;
            if (timeLeft < 0)
            {
                if (shakes > shakeBoomBottle)
                {
                    winParticles.SetActive(true);
                    counterScirpt.hasPlayerWon = true;
                }
                timeLeft = 1;
            }
        }
    
    
    
}
