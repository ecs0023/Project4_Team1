using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class EnemyController : MonoBehaviour
{
    public int Speed;
    public int Health;
    public GameObject player;
    public GameObject enemy;

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        enemy = GameObject.FindGameObjectWithTag("Enemy");
    }
    void Update()
    {

    }

    public void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Debug.Log("In Range");
        }
    }

    public void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Debug.Log("Left Range");
        }
    }
}
