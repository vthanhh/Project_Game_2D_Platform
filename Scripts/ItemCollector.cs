using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemCollector : MonoBehaviour
{
    private int stars = 0;

    [SerializeField] private Text StarsText;

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Collect"))
        {
            Destroy(collision.gameObject);
            stars++;
            StarsText.text = "Stars: " + stars;
        }
    }
}
