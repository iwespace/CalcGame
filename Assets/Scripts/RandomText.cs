using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RandomText : MonoBehaviour {

    [SerializeField]
    private Text text;

	// Use this for initialization
	void Start () {

        var randomNumber = Random.Range(0, 10);
        randomNumber += 1;
        text.text = "Random : " + randomNumber.ToString();

    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
