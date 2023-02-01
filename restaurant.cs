using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class restaurant : MonoBehaviour
{
    //[SerializeField] private GameObject cute;

    // Start is called before the first frame update
    void Start()
    {

    }
    //public void click()
    // {
    //cute.gameObject.SetActive(true);
    //StartCoroutine(wait());

    //}
    public void OnClickGame()
    {
        //yield return new WaitForSeconds(8);

        SceneManager.LoadScene("restaurant");

    }
    // Update is called once per frame

}
