using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SF¼Ò¼³doubleclick : MonoBehaviour
{
    public GameObject Notification;
    int x = 1;

    // Start is called before the first frame update
    void Start()
    {
        Notification.SetActive(false);
    }


    // Update is called once per frame
    public void OnClickGame()
    {
        x -= 1;

        Notification.SetActive(true);

    }


}
