using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemMaker3 : MonoBehaviour
{
    public GameObject ItemPrefab;
    float interval = 0.8f;
    float delta = 0;

    // Update is called once per frame
    void Update()
    {
        delta += Time.deltaTime;
        if (delta > interval)
        {
            delta = 0;
            GameObject Item = Instantiate(ItemPrefab) as GameObject;
            int x = Random.Range(-6, 100);
            Item.transform.position = new Vector3(x, 3, 0);
        }
    }
}
