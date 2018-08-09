using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MasterSounds : MonoBehaviour {
    public AudioSource masterSound;

    public AudioSource hdd1;
    public AudioSource hdd2;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (hdd1.isPlaying || hdd2.isPlaying)
        {
            masterSound.Stop();
        }
        else if (!hdd1.isPlaying && !hdd2.isPlaying && !masterSound.isPlaying)
        {
            masterSound.Play();
        }
    }
}
