using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectCollision : MonoBehaviour
{
    public GameObject tomato;
    public GameObject cabbage;
    void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.tag == "tomato")
        {
            tomato.gameObject.SetActive(false);
        }

        if (collision.gameObject.tag == "cabbage")
        {
            cabbage.gameObject.SetActive(false);
        }
    }
}
