using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;





public class AnswerButton : MonoBehaviour {
    public Text Ans = null;
    public Text AnsPlus = null;
    public Text AnsMinus = null;
    public RandomText randomText;

	// Use this for initialization
	void Start () {
        Debug.Log(randomText.RandomNumber1 + randomText.RandomNumber2);
        Ans.text = (randomText.RandomNumber1 + randomText.RandomNumber2).ToString();
        AnsPlus.text = (randomText.RandomNumber1 + randomText.RandomNumber2 + 1).ToString();
        AnsMinus.text = (randomText.RandomNumber1 + randomText.RandomNumber2 - 1).ToString();
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
