using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Screenshots : MonoBehaviour {

    CaptureAndSave snapShot;
    public GameObject buttonCapture;

    public Texture2D tex;

    // Use this for initialization
    void Start () {
        snapShot = GameObject.FindObjectOfType<CaptureAndSave>();
        Debug.Log(System.Environment.GetFolderPath(System.Environment.SpecialFolder.MyPictures));
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    IEnumerator delaySS(float delay)
    {
        buttonCapture.SetActive(false);
        yield return new WaitForSeconds(delay);

        snapShot.CaptureAndSaveToAlbum();
        //snapShot.SaveTextureToGallery(tex);

        yield return new WaitForSeconds(delay);
        buttonCapture.SetActive(true);

    }

    public void CaptureScreenshots()
    {
        StartCoroutine(delaySS(0.5f));
    }

    string GenerateFileName()
    {
        
        return Application.persistentDataPath + "/HHDnHKD/" + System.DateTime.Now.ToString("yyyy-MM-dd_HH-mm-ss") + ".jpg";
    }
}
