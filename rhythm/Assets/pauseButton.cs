using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class pauseButton : MonoBehaviour
{
    public GameObject level;
    public GameObject quitbutton;
    public GameObject restartbutton;
    public AudioSource music;
    public bool paused;
    public Sprite resumesp;
    public Sprite pausesp;
    // Start is called before the first frame update
    void Start()
    {
        Color co = GetComponent<Image>().color;
        co.a = 1f;
        GetComponent<Image>().color = co;
        StartCoroutine("FadeOut");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void pause()
    {
        if(paused == false)
        {
            //pause
            quitbutton.SetActive(true);
            restartbutton.SetActive(true);
            GetComponent<Image>().sprite = resumesp;
            Color co = GetComponent<Image>().color;
            co.a = 1f;
            GetComponent<Image>().color = co;
            level.GetComponent<noteFall>().moving = false;
            music.Pause();
            paused = true;
        }
        else if(paused == true)
        {
            //resume
            this.GetComponent<Image>().sprite = pausesp;
            Color co = GetComponent<Image>().color;
            co.a = 0f;
            GetComponent<Image>().color = co;
            quitbutton.SetActive(false);
            restartbutton.SetActive(false);
            level.GetComponent<noteFall>().moving = true;
            music.Play();
            paused = false;
        }
        
    }

    IEnumerator FadeOut()
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
