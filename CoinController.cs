using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinController : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D Col)
    {
        if(Col.gameObject.tag == "Player")
        {
            Score1.score += 100;
            Destroy(gameObject);
        }
    }
}
