using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms;
using UnityEngine.UI;

public class Dialogue : MonoBehaviour
{
    public GameObject Canvas;
    public void Start()
    {
        Canvas.gameObject.SetActive(false);
    }

    public void Update()
    {
        if(Input.GetKeyDown(KeyCode.Tab))
        {
            Canvas.gameObject.SetActive(true);
        }
        if (Input.GetKeyUp(KeyCode.Tab))
        {
            Canvas.gameObject.SetActive(false);
        }
    }
}
