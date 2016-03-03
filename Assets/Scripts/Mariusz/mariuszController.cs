using UnityEngine;
using System.Collections;

public class mariuszController : MonoBehaviour {
    public Vector3 nonUserMovement;
    public Vector3 userMovement;
    public GameObject sayMyName;
    private AudioSource shout;
    // Use this for initialization
	void Start () {
        shout = this.GetComponent<AudioSource>();
        Invoke("saymyname", 0.1f);
	}
    void saymyname() {
        sayMyName.SetActive(true);
    }

	// Update is called once per frame
	void Update () {
        this.transform.Translate(nonUserMovement);
        if (controls.spacePressed) {
            this.transform.Translate(userMovement);
            shout.Play();
            shout.volume += 0.03f;
        }
	}
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Choco")
        {
            counterScirpt.hasPlayerWon = true;
        }
    }
}
