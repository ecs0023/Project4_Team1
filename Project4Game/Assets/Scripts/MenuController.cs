using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class MenuController : MonoBehaviour
{
    void Start()
    {

    }
    void Update()
    {

    }
    public void FirstLevel()
    {
        SceneManager.LoadScene("Level1");
    }

    public void SecondLevel() 
    {
        SceneManager.LoadScene("Level2");
    }
}
