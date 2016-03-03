using UnityEngine;
using System.Collections;

public class landerController : MonoBehaviour {
    public Vector3 movementR;
    public Vector3 upGoes;
    public Vector3 rotateR;
    private Vector3 rotateL;
    public float turbo;
    public GameObject emitter;
    private ParticleSystem.EmissionModule em;
    private Vector3 movementL;
    private Rigidbody rb;
    private AudioSource aS;
	// Use this for initialization
	void Awake () {
        aS = emitter.GetComponent<AudioSource>();
        rb=this.GetComponent<Rigidbody>();
        movementL = new Vector3(-movementR.x, movementR.y, movementR.z);
        rotateL = new Vector3(-rotateR.x, -rotateR.y, -rotateR.z);
        em= emitter.GetComponent<ParticleSystem>().emission;
    }
	
	// Update is called once per frame
	void Update () {
        if (controls.leftPressed){
            this.transform.Rotate(rotateR);
        }
        if (controls.rightPressed){
            this.transform.Rotate(rotateL);
        }
        if (controls.upPressed)
        {
            if (!aS.isPlaying)
            {
                aS.Play();
            }
            em.enabled = true;
            rb.AddRelativeForce(upGoes * turbo, ForceMode.Force);
        }
        else
        {
            em.enabled = false;
        }
        
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Choco")
        {
            Destroy(this.GetComponent<Rigidbody>());
            counterScirpt.hasPlayerWon = true;
        }
    }
}
