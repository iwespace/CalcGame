using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RandomText : MonoBehaviour
{

    [Header("UI")]
    [SerializeField]
    private Text randomText1;
    [SerializeField]
    private Text randomText2;

    // Use this for initialization
    void Start () {

        var randomNumber1 = Random.Range(0, 10);
        randomNumber1 += 1;
        var randomNumber2 = Random.Range(0, 10);
        randomNumber2 += 1;

        randomText1.text = randomNumber1.ToString();
        randomText2.text = randomNumber2.ToString();

    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
