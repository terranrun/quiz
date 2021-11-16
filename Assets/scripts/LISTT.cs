using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LISTT : MonoBehaviour
{
    public int I;
    public GameObject[] tasks;
    void Start()
    {
        tasks = GameObject.FindGameObjectsWithTag("TASK");
        I = Random.Range(0, tasks.Length);
        tasks[I].transform.GetChild(0).gameObject.active = true;
    }

    // Update is called once per frame
    public void Randowm()
    {
        tasks = null;
        tasks = GameObject.FindGameObjectsWithTag("TASK");
        I = Random.Range(0, tasks.Length);
        tasks[I].transform.GetChild(0).gameObject.active = true;
    }
}
