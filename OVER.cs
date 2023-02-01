using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OVER : MonoBehaviour
{
    public void OnClickGame()
    {
        SceneManager.LoadScene("mainmap");
    }
}
