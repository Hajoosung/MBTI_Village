using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Score1 : MonoBehaviour
{
    Text text;
    public static int score;
    void Start()
    {
        text = GetComponent<Text>();
    }
    void Update()
    {
        text.text = score.ToString();

        if (score > 200)
        {
            SceneManager.LoadScene("CoinScenes");
        }
    }
}
