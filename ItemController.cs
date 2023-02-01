using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemController : MonoBehaviour
{
    GameObject G;

    void Start()
    {
        this.G = GameObject.Find("G");
    }

    void Update()
    {
        transform.Translate(0, -0.01f, 0);
        if(transform.position.y < -3.0f)
        {
            Destroy(gameObject);
        }
    }
}
