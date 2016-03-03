using UnityEngine;
using System.Collections;

public class lowerBroethenControler : MonoBehaviour {
    public GameObject upperBroethen;
    public Vector3 bakeryMovement;
    private Vector3 inversedBakeryMovement;
    private AudioSource aS;
	// Use this for initialization
	void Start () {
        
        inversedBakeryMovement = new Vector3(bakeryMovement.x, -bakeryMovement.y, bakeryMovement.z);
        aS=this.GetComponent<AudioSource>();
    }
	
	// Update is called once per frame
	void Update () {
        if (controls.spacePressed)
        {
            pinTheSausage();
        }
	}
    void OnCollisionEnter(Collision collision) {
        if (collision.gameObject.name == "parowka") {
            CancelInvoke("moveTheBakery");
            aS.Play();
            Destroy(this.GetComponent<Rigidbody>());
            Destroy(upperBroethen.GetComponent<Rigidbody>());
            counterScirpt.hasPlayerWon = true;
        }
    }
    void pinTheSausage() {
        InvokeRepeating("moveTheBakery",0.0f,0.01f);
    }
    void moveTheBakery() {
        this.transform.Translate(bakeryMovement);
        upperBroethen.transform.Translate(inversedBakeryMovement);
    }

}
