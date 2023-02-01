using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemDestory : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D col)
    {
        GameObject HP = GameObject.Find("HPControl");

        if(col.gameObject.tag == "Player")
        {
            HP.GetComponent<HpController>().HpControl();

        }

        Destroy(gameObject);
    }
}
