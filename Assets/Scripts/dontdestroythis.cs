using UnityEngine;
using System.Collections;

public class dontdestroythis : MonoBehaviour {
    void Awake()
    {
        DontDestroyOnLoad(this.transform.gameObject);
    }
}
