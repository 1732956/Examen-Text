using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextDisplay : MonoBehaviour {
    public GameObject BangText;
    public AudioSource audioSource;
    float TimeAlive;
    public Text displayText;

    private bool hasClick;
    // Use this for initialization
    void Start () {
        audioSource = GetComponent<AudioSource>();

    }
	
	// Update is called once per frame
	void Update () {

        if (Input.GetAxis("Fire1") != 0)
        {

            if (hasClick==false)
            {
       
                Instantiate(BangText);
                audioSource.Play();
            }
           

            hasClick = true;
        }
        else
        {

            hasClick = false;
        }
	}
}
