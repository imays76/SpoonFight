using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonBehavior : MonoBehaviour {
    public GameObject ButtonText;
    public int Score = 0;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void AddScore()
    {
        Score = Score + 1;
        ButtonText.GetComponentInChildren<Text>().text = "Score: " + Score.ToString();
    }
}
