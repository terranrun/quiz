using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class newScen : MonoBehaviour
{
    public string nameScene;
    public static int celoe = 0;
    
    
    public void lvl()
    {
        
            
        SceneManager.LoadScene(nameScene);
    }
    public void lvl1()
    {
        
        celoe = 1;
        

        SceneManager.LoadScene(nameScene);
    }
    public void lvl2()
    {

        celoe = 2;


        SceneManager.LoadScene(nameScene);
    }
    public void lvl3()
    {
        if(celoe == 2)
        {
            SceneManager.LoadScene(nameScene);
        }

    }

    public void exit()
    {
        Application.Quit(); 
    }


}
