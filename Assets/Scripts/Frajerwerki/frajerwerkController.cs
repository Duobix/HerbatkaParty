using UnityEngine;
using System.Collections;

public class frajerwerkController : MonoBehaviour {
    public Vector3 movementR;
    public Vector3 upGoes;
    public Vector3 rotateR;
    public bool wentBoom;
    private Vector3 rotateL;
    public float turbo;
    public GameObject meshRendererObjects;
    public GameObject explosionElement;
    public GameObject pro1;
    public GameObject pro2;
    public GameObject pro3;
    public GameObject pro4;
    
    private Vector3 movementL;
    private Rigidbody rb;
	// Use this for initialization
	void Awake () {
        rb=this.GetComponent<Rigidbody>();
        movementL = new Vector3(-movementR.x, movementR.y, movementR.z);
        rotateL = new Vector3(-rotateR.x, -rotateR.y, -rotateR.z);
    }
	
	// Update is called once per frame
	void Update () {
        if (controls.spacePressed)
        {
            wentBoom = true;
        }

        
        rb.AddRelativeForce(upGoes * turbo, ForceMode.Force);
        if (this.transform.position.y > 30) {
            this.transform.position = new Vector3(this.transform.position.x, -30.0f, this.transform.position.z);
            wentBoom=false;
        }
    }

    void OnTriggerStay(Collider collision)
    {
        if (collision.gameObject.name == "Choco"&&wentBoom)
        {
            //for (int i = 0; i < 100; i++) {
            //    Instantiate(explosionElement,this.transform.position,Quaternion.identity);
            //}
            Invoke("activate1", 0.0f);
            //GetComponent<MeshRenderer>().enabled = false;
            meshRendererObjects.SetActive(false);
            counterScirpt.hasPlayerWon = true;
        }
    }

    private void activate1() {
        pro1.SetActive(true);
        Invoke("activate2", 0.7f);
    }
    private void activate2()
    {
        pro2.SetActive(true);
        Invoke("activate3", 0.7f);

    }
    private void activate3()
    {
        pro3.SetActive(true);
        Invoke("activate4", 0.7f);

    }
    private void activate4()
    {
        pro4.SetActive(true);

    }
}
