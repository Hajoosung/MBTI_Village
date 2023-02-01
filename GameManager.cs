using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public float GameTime = 5;
    public Text GameTimeText;

    void Update()
    {
        if ((int)GameTime == -1)
        {
            GameTimeText.text = "���� ��� �Ⱦ��ϴ� ����?";
        }
        else
        {
            GameTime -= Time.deltaTime;
            //GameTimeText.text = "������������" + (int)GameTime;
        }
    }
}
