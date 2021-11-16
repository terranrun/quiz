using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TRUEE : MonoBehaviour
{
    public int Score;
    public TMP_Text score;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        score.text = Score.ToString();
    }
}
