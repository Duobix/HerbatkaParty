using UnityEngine;
using System.Collections;

public class parowkaContoler : MonoBehaviour {
    public Vector3 parowkaMovement;
	// Use this for initialization
	void Start () {
        InvokeRepeating("moveParowka", 0.0f, 0.05f);	
	}

    private void moveParowka() {
        this.transform.Translate(parowkaMovement);
    }

    void OnCollisionEnter(Collision collision) {
        CancelInvoke("moveParowka");
    }
}
