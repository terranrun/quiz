using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class task : MonoBehaviour
{
    public TextAsset All;
    string Text;
    public string Task;
    public string Answers;
    public TMP_Text Tesk;
    public TMP_Text a1;
    public TMP_Text a2;
    public TMP_Text a3;
    public TMP_Text a4;
    public string True;

    void Start()
    {
        Text = All.text;
        string[] s = Text.Split('/');
        Task = s[0];
        Answers = s[1];
        True = s[2];
        Tesk.text = Task;
        string[] A = Answers.Split(';');
        a1.text = A[0];
        a2.text = A[1];
        a3.text = A[2];
        a4.text = A[3];
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
