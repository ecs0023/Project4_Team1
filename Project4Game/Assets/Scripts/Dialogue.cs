using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms;
using UnityEngine.UI;

public class Dialogue : MonoBehaviour
{
    public GameObject Textbox;
    public void Start()
    {
        Textbox.gameObject.SetActive(false);
    }

    public void Update()
    {
        if(Input.GetKeyDown(KeyCode.Tab))
        {
            Textbox.gameObject.SetActive(true);
        }
        if (Input.GetKeyUp(KeyCode.Tab))
        {
            Textbox.gameObject.SetActive(false);
        }
    }
}
