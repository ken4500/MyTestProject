using UnityEngine;
using System.Collections;

public class Animal : MonoBehaviour {

    // Use this for initialization
    void Start() {

    }

    // Update is called once per frame
    void Update() {

    }

    void OnTriggerEnter(Collider col)
    {
        if (col.CompareTag("Player"))
        {
            iTween.FadeTo(gameObject, iTween.Hash("alpha", 0, "time", 1.0f, "oncomplete", "Die"));
        }
    }

    public void Die()
    {

    }
}
