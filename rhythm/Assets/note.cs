using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class note : MonoBehaviour
{

    public GameObject pointManager;
    public GameObject comboManager;
    public int number;

    // Start is called before the first frame update
    void Start()
    {
        pointManager = GameObject.Find("score");
        comboManager = GameObject.Find("combo");
        //Invoke("debugpos", 2f + 4.5f * 0.6666666666666667f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "destroy")
        {
            pointManager.GetComponent<pointManager>().miss();
            comboManager.GetComponent<combomanager>().combo = 0f;
            comboManager.GetComponent<Text>().color = Color.white;
            //level.GetComponent<noteFall>().notes.Remove(this.gameObject);
            Destroy(this.gameObject);
        }
    }

    void debugpos()
    {
        Debug.Log(transform.position + ": " + number);
    }
}
