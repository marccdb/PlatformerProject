using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickuos : MonoBehaviour
{

    [SerializeField] AudioClip coinSfx;
    [SerializeField] int coinValue = 10;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        AudioSource.PlayClipAtPoint(coinSfx, Camera.main.transform.position);
        FindObjectOfType<GameSession>().AddToScore(coinValue);
        Destroy(gameObject);
    }



}
