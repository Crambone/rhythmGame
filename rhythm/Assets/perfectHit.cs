using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class perfectHit : MonoBehaviour
{
    public bool touched;

    public GameObject touchedNote;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "rightNote" || other.tag == "leftNote" || other.tag == "upNote" || other.tag == "downNote" || other.tag == "longRightNote" || other.tag == "longUpNote")
        {
            touchedNote = other.gameObject;
            touched = true;
        }
    }

    void OnTriggerExit2D(Collider2D other)
    {
        if(other.tag == "rightNote" || other.tag == "leftNote" || other.tag == "upNote" || other.tag == "downNote" || other.tag == "longRightNote" || other.tag == "longUpNote")
        {
            touchedNote = null;
            touched = false;
        }
    }   
}
