using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game : MonoBehaviour {
	public GameObject Banner;
    public GameObject Banner2;
	public AudioSource Dubbing;
	public Animator anim;


    // Use this for initialization
    void Start () {
		Banner.SetActive (false);
        Banner2.SetActive(false);

       
    }
	
	// Update is called once per frame
	void Update () {
		
	}

	public void ShowBanner()
	{
		Banner.SetActive (true);
		Dubbing.Play ();

		StartCoroutine (waitDelay (4));

	}

	IEnumerator waitDelay(float delay)
	{
        yield return new WaitForSeconds(0.8f);
        Banner2.SetActive(true);

        yield return new WaitForSeconds (delay);
		Banner.SetActive (false);
        Banner2.SetActive(false);
        anim.Play (0);
	}
    

	/*public void ShowBanner(int index)
	{
		for (int i = 0; i < Banner.Length; i++) {
			if (i == index) {
				Banner [i].SetActive (true);
			} else {
				Banner [i].SetActive (false);
			}

		}
	}

	void PlayDubbing(int index)
	{
		for (int i = 0; i < Dubbing.Length; i++) {
			if (i == index) {
				Dubbing [i].Play ();
			} else {
				Dubbing [i].Stop ();
			}

		}
	}
	*/
}
