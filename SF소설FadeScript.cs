using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SF소설FadeScript : MonoBehaviour
{
    public Image Panelout;

    float time = 0f;
    float F_time = 0.8f;


    public void Start()
    {

        StartCoroutine(Fadein());

    }
    IEnumerator Fadein()
    {
        Panelout.gameObject.SetActive(true);
        Color alpha = Panelout.color;
        while (alpha.a > 0f)
        {
            time += Time.deltaTime / F_time;
            alpha.a = Mathf.Lerp(1, 0, time);
            Panelout.color = alpha;


            yield return null;


        }
        Panelout.gameObject.SetActive(false);

    }
    public void Fade()
    {
        StartCoroutine(FadeFlow());
    }
    IEnumerator FadeFlow()
    {
        Panelout.gameObject.SetActive(true);
        time = 0f;
        Color alpha = Panelout.color;
        while (alpha.a < 1f)
        {
            time += Time.deltaTime / F_time;
            alpha.a = Mathf.Lerp(0, 1, time);
            Panelout.color = alpha;
            yield return null;
        }
        SceneManager.LoadScene("SF소설구매씬");
    }
}
