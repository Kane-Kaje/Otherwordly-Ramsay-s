using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectCollision : MonoBehaviour
{
    void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.tag == "stove") {
            print("You hit the stove!");
        }

        if (collision.gameObject.tag == "kitchen_counter") {
            print("You hit the kitchen counter!");
        }

        if (collision.gameObject.tag == "tomato") {
            print("You hit the tomato!");
        }

        if (collision.gameObject.tag == "cabbage") {
            print("You hit the cabbage!");
        }

        if (collision.gameObject.tag == "trash_can") {
            print("You hit the trash can!");
        }
    }

    void OnTriggerStay(Collider collision)
    {
        if (collision.gameObject.tag == "stove") {
            print("You're still hitting the stove.");
        }

        if (collision.gameObject.tag == "kitchen_counter") {
            print("You're still hitting the kitchen counter.");
        }

        if (collision.gameObject.tag == "tomato") {
            print("You're still hitting the tomato.");
        }

        if (collision.gameObject.tag == "cabbage") {
            print("You're still hitting the cabbage.");
        }

        if (collision.gameObject.tag == "trash_can") {
            print("You're still hitting the trash can.");
        }
    }

    void OnTriggerExit(Collider collision)
    {
        if (collision.gameObject.tag == "stove") {
            print("You stop hitting the stove.");
        }

        if (collision.gameObject.tag == "kitchen_counter") {
            print("You stop hitting the kitchen counter.");
        }

        if (collision.gameObject.tag == "tomato") {
            print("You stop hitting the tomato.");
        }

        if (collision.gameObject.tag == "cabbage") {
            print("You stop hitting the cabbage.");
        }

        if (collision.gameObject.tag == "trash_can") {
            print("You stop hitting the trash can.");
        }
    }
}