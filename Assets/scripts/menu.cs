using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class menu : MonoBehaviour
{
    public GameObject ScreenToDisable;
    public GameObject ScreenToEnable;
    public GameObject ScreenToEnable1;


    public void Open1()
    {
        
        ScreenToDisable.SetActive(false);
        ScreenToEnable.SetActive(true);
        ScreenToEnable1.SetActive(true);


    }
}