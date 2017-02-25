using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayRandomSound : MonoBehaviour {

    public List<AudioClip> m_audioClips = new List<AudioClip>();
    public AudioSource m_audioSource;

	// Use this for initialization
	void Start () {
        m_audioSource = GetComponent<AudioSource>();

    }
	
	// Update is called once per frame
	void Update () {
		
	}

    public void Play()
    {
        int index = Random.Range(0, m_audioClips.Count-1);
        m_audioSource.PlayOneShot(m_audioClips[index], 1);
    }
}
