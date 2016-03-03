using UnityEngine;
using System.Collections;

public class czajnikController : MonoBehaviour {
    public Vector3 movementR;
    public Vector3 upGoes;
    public Vector3 rotateR;
    public GameObject winParticles;
    private Vector3 rotateL;
    public float turbo;

    private Vector3 movementL;
    private Rigidbody rb;
    private float timeLeft;
    private bool datTemp;
	void Awake () {
        datTemp = false;
        timeLeft = 3;
        rb=this.GetComponent<Rigidbody>();
        movementL = new Vector3(-movementR.x, movementR.y, movementR.z);
        rotateL = new Vector3(-rotateR.x, -rotateR.y, -rotateR.z);
    }
	
	// Update is called once per frame
	void Update () {
        if (controls.spacePressed){
            rb.AddRelativeForce(upGoes * turbo, ForceMode.Force);
        }
        if (datTemp) {
            timeLeft -= Time.deltaTime;
            if (timeLeft < 0)
            {
                winParticles.SetActive(true);
                counterScirpt.hasPlayerWon = true;
            }
        }
        
        
    }
    void OnTriggerExit(Collider collision) {
        if (collision.gameObject.name == "Choco")
        {
            datTemp = false;
        }
    }
    void OnTriggerEnter(Collider collision)
    {
        timeLeft = 3;
    }
        void OnTriggerStay(Collider collision)
    {
        if (collision.gameObject.name == "Choco")
        {
            datTemp = true;
            //counterScirpt.hasPlayerWon = true;
        }
    }
}
