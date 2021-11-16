using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class BTN_TXT : MonoBehaviour
{
    public GameObject VPR;
    public Color gr;
    public Color fl;
    public Image th;
    public TMP_Text t;
    public task task;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    public void Check()
    {
        if(t.text == task.True)
        {
            th.color = gr;
            StartCoroutine(Wait());
        }
        else
        {
            
            th.color = fl;
            StartCoroutine(Wait());
        }
    }
    IEnumerator Wait()
    {
        yield return new WaitForSeconds(2);
        VPR.active = false;
    }
}
