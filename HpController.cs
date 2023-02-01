using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class HpController : MonoBehaviour
{
    GameObject HP;

    void Start()
    {
        HP = GameObject.Find("HP");
    }

    public void HpControl()
    {
        HP.GetComponent<Image>().fillAmount -= 0.1f;

        if (HP.GetComponent<Image>().fillAmount <= 0.9)
        {
            SceneManager.LoadScene("OverMiniGame");
        }
    }
}
