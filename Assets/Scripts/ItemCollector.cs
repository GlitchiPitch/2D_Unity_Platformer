using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemCollector : MonoBehaviour
{
    private int bananas = 0;

    [SerializeField] private Text bananasText;
    [SerializeField] private AudioSource collectSound;
    // Start is called before the first frame update
    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.gameObject.CompareTag("Banana"))
        {
            collectSound.Play();
            Destroy(collision.gameObject);
            bananas++;
            Debug.Log("Bananas: " + bananas);
            bananasText.text = "Bananas: " + bananas;
        }
    }


}
