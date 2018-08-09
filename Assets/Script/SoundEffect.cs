using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundEffect : MonoBehaviour {
	public AudioSource BarangKeras2;
	public AudioSource BotolPlastik;
	public AudioSource Buah;
	public AudioSource KalengBotol;
	public AudioSource Kertas;
	public AudioSource Kumpulan;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void PlayBarangKeras2()
	{
		BarangKeras2.Play ();
	}
	public void PlayBotolPlastik()
	{
		BotolPlastik.Play ();
	}
	public void PlayBuah()
	{
		Buah.Play ();
	}
	public void PlayKalengBotol()
	{
		KalengBotol.Play ();
	}
	public void PlayKertas()
	{
		Kertas.Play ();
	}
	public void PlayKumpulan()
	{
		Kumpulan.Play ();
	}
}
