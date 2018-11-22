using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
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
}
