using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pin : MonoBehaviour
{
    private bool isPinned = false;

    public float speed = 20f;
    public Rigidbody2D rg;

    private void Update()
    {
        if (isPinned == false)
        {
            rg.MovePosition(rg.position + Vector2.up * speed * Time.deltaTime);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Rotator")
        {
            transform.SetParent(collision.transform);
            Score.PintCount++;
            isPinned = true;
        }
        else if (collision.tag == "Pin")
        {
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
