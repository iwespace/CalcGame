﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public Button Ans = null;
    public Button AnsPlusBtn = null;
    public Button AnsMinusBtn = null;
    [SerializeField]
    private RandomText randomText;


    public void OnAnsClick(Text buttonText)
    {
        int value = int.Parse(buttonText.text);
        Debug.Log(IsCollectAnswer(value) ? "정답" : "오답");
    }

    private bool IsCollectAnswer(int value)
    {
        return randomText.Answer == value;
    }


	// Use this for initialization
	void Start () {
        int pos = Random.Range(-600, 600);
        Vector3 Vpos = new Vector3(pos, pos);
        Ans.transform.position = Vpos;
        AnsPlusBtn.transform.position = Vpos;
        AnsMinusBtn.transform.position = Vpos;
    }
	
	// Update is called once per frame
	void Update () {
		
	}

}
