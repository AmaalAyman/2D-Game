using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemCollector : MonoBehaviour
{
    private int cherries = 0;
    private int oranges = 0;
    private int melons = 0;

    [SerializeField] private Text cherriesText;
    [SerializeField] private Text OrangesText;
    [SerializeField] private Text MelonsText;
    [SerializeField] private AudioSource collectionSoundEffect;
    private AudioSource audios;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Cherry"))
        {
            collectionSoundEffect.Play();
            audios = GetComponent<AudioSource>();
            Destroy(collision.gameObject);
            cherries++;
            cherriesText.text = "Cherries: " + cherries;
        }

        else if (collision.gameObject.CompareTag("Orange"))
        {
            collectionSoundEffect.Play();
            audios = GetComponent<AudioSource>();
            Destroy(collision.gameObject);
            oranges++;
            Debug.Log("oranges: " + oranges);
            OrangesText.text = "Oranges: " + oranges;
        }
        else if (collision.gameObject.CompareTag("Melon"))
        {
            collectionSoundEffect.Play();
            audios = GetComponent<AudioSource>();
            Destroy(collision.gameObject);
            melons++;
            Debug.Log("melons: " + melons);
            MelonsText.text = "Melons: " + melons;
        }
    }

}
