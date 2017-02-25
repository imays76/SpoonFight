using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StopBGM : MonoBehaviour {
    public AudioSource m_BGMSource;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void Action()
    {
        m_BGMSource.Stop();
    }
}
