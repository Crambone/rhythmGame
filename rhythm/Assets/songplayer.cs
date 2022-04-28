using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class songplayer : MonoBehaviour
{
    public AudioSource song;
    public AudioSource tick;
    public float bpm;
    public float offset;
    public GameObject noteFall;
    public float editorOffset;
    // Start is called before the first frame update
    void Start()
    {
        Invoke("playSong", 2 + offset);
        //InvokeRepeating("metronome", 0.6666666666666667f * 4f + 0.6666666666666667f/2f, 0.6666666666666667f/2f);  
        bpm = 90f;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void playSong()
    {
        song.Play();
    }

    public void metronome()
    {
        tick.Play();
    }
}
