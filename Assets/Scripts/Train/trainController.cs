using UnityEngine;
using System.Collections;

public class trainController : MonoBehaviour {
    public Vector3 movementR;
    public Vector3 upGoes;
    public Vector3 rotateR;
    public Vector3 antiEnter;
    private Vector3 rotateL;
    private float userHang;
    public float turbo;
    private Vector3 movementL;
    private Rigidbody rb;
    private float antiturbo;
    public GameObject parti;
    public GameObject parti1;
    public GameObject chagachaga;
    // Use this for initialization
    void Awake () {
        userHang = 0;
        rb=this.GetComponent<Rigidbody>();
        movementL = new Vector3(-movementR.x, movementR.y, movementR.z);
        rotateL = new Vector3(-rotateR.x, -rotateR.y, -rotateR.z);
        antiturbo = turbo / -4.0f;
    }
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            //rb.AddRelativeForce(upGoes * turbo, ForceMode.Force);
            this.transform.Translate(upGoes);
            rb.AddRelativeForce(upGoes * turbo * userHang, ForceMode.Force);
            userHang+=0.12f;
        }
        else
        {
            rb.AddRelativeForce(upGoes * antiturbo, ForceMode.Force);
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Choco")
        {
            Destroy(this.GetComponent<Rigidbody>());
            counterScirpt.hasPlayerWon = true;
            chagachaga.SetActive(false);
        }
        if (collision.gameObject.name == "Enter")
        {
            Destroy(collision.gameObject);
            this.transform.Translate(antiEnter);
            parti.SetActive(true);
        }
        if (collision.gameObject.name == "Enter1")
        {
            Destroy(collision.gameObject);
            this.transform.Translate(antiEnter);
            parti1.SetActive(true);
        }
    }
}
