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
            GameTimeText.text = "∞°¿Â µË±‚ Ω»æÓ«œ¥¬ ∏ª¿∫?";
        }
        else
        {
            GameTime -= Time.deltaTime;
            //GameTimeText.text = "πŒ¡§πŒ¡§πŒ¡§" + (int)GameTime;
        }
    }
}
