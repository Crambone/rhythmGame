using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class restartbutton : MonoBehaviour
{
    public GameObject level;
    public AudioSource music;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void restart()
    {
        SceneManager.LoadSceneAsync(SceneManager.GetActiveScene().buildIndex);
        Debug.Log("afsd");
    }

    IEnumerator FadeIn()
    {
        for(float f = 1f; f >= 0f; f -= 0.05f)
        {
            Color c = GetComponent<Image>().color;
            c.a = f;
            GetComponent<Image>().color = c;
            yield return new WaitForSeconds(0.05f);
        }

        Color co = GetComponent<Image>().color;
        co.a = 0f;
        GetComponent<Image>().color = co;
    }
}
