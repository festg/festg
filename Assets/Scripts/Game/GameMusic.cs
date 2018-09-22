using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameMusic : MonoBehaviour {

    [SerializeField]
    List<AudioClip> audioClips;

    [SerializeField]
    AudioSource audioSource;

	// Use this for initialization
	void Start () {
        if (audioClips.Count != 0)
        {
            audioSource.clip = audioClips[(int)Mathf.Floor(Random.value * audioClips.Count)];
            audioSource.Play();
        }
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
