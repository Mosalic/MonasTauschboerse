using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicPlayer : MonoBehaviour {

    public AudioClip[] clips;
    private AudioSource audioSource;
    private int clipIndex;

	// Use this for initialization
	void Start () {
        audioSource = GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update () {
        if (!audioSource.isPlaying)
        {
            // if (Input.GetKey("p")){
            audioSource.clip = GetClip();
            audioSource.Play();
            // }
        }
        if (Input.GetKeyDown("n")) {
            Debug.Log("N");
            SetNextClip();
        }
        /*else{
            if (Input.GetKey("p"))
            {
               // audioSource.clip = GetClip();
                audioSource.Pause();
            }
        }*/
	}

    private AudioClip GetClip() {
        return clips[clipIndex];
    }

    private void SetNextClip(){
        if (audioSource.isPlaying) {
            audioSource.Stop();

            if (clipIndex < clips.Length -1){
                clipIndex++;
            }
            else {
                clipIndex = 0;
            }

            audioSource.clip = GetClip();
            audioSource.Play(); 
        }
    }
}
