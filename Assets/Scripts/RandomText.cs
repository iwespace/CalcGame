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

    public int RandomNumber1 { get; private set; }
    public int RandomNumber2 { get; private set; }
    public int Answer
    {
        get
        {
            return RandomNumber1 + RandomNumber2;
        }
    }

    // Use this for initialization
    void Awake () {

        RandomNumber1 = Random.Range(0, 10);
        RandomNumber1 += 1;
        RandomNumber2 = Random.Range(0, 10);
        RandomNumber2 += 1;

        randomText1.text = RandomNumber1.ToString();
        randomText2.text = RandomNumber2.ToString();

    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
