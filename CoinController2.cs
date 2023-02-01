using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinController2 : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D Col)
    {
        if (Col.gameObject.tag == "Player")
        {
            Score1.score += 500;
            Destroy(gameObject);
        }
    }
}
