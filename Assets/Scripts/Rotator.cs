using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Rotator : MonoBehaviour {

    public GameObject PickUps;

    void Start()
    {
        float x = 0;
        float z = 0;
        foreach(Transform child in PickUps.transform)
        {
            x = Random.Range(-10.0f, 10.0f);
            z = Random.Range(-10.0f, 10.0f);
            child.position = new Vector3(x, 0, z);
        }
    }

    // Update is called once per frame
    void Update () {
        transform.Rotate(new Vector3 (15, 30, 45) * Time.deltaTime);
	}
}
