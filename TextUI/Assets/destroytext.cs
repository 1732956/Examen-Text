using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroytext : MonoBehaviour {
    float timeAlive =0;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        timeAlive +=Time.deltaTime;

        if (timeAlive>=2)
        {
            Destroy(gameObject);
        }

    }
}
