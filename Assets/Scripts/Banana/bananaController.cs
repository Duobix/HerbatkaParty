using UnityEngine;
using System.Collections;

public class bananaController : MonoBehaviour {
    public Vector3 movementR;
    public Vector3 movementDown;
    private Vector3 movementL;
    public GameObject chocolateRain;
    private bool hitChoco;
	// Use this for initialization
	void Awake () {
        hitChoco = false;
        movementL = new Vector3(-movementR.x, movementR.y, movementR.z);
	}
	
	// Update is called once per frame
	void Update () {
        if (controls.leftPressed){
            this.transform.Translate(movementL);
        }
        if (controls.rightPressed){
            this.transform.Translate(movementR);

        }
        if (hitChoco == false)
        {
            this.transform.Translate(movementDown);
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Choco")
        {
            chocolateRain.SetActive(true);
            hitChoco = true;
            //CancelInvoke("moveTheBakery");
            Destroy(this.GetComponent<Rigidbody>());
            //Destroy(upperBroethen.GetComponent<Rigidbody>());
            counterScirpt.hasPlayerWon = true;
        }
    }
}
