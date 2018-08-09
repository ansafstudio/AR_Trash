using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HDDmgr : MonoBehaviour {
    public AudioSource sfx;
	public Animator anim;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (!anim.isActiveAndEnabled)
        {
            sfx.Stop();
            //sfx.Pause();
        }
        else if (anim.isActiveAndEnabled && !sfx.isPlaying)
        {
            sfx.Play();
        }
    }

    public void PlaySFX()
    {
        sfx.Play();
    }
}
