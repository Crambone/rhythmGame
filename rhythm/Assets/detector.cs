using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class detector : MonoBehaviour
{
    public bool touched;
    public GameObject touchedNote;
    public List<GameObject> notesInRange = new List<GameObject>();
    public float noteDistance;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(notesInRange.Count > 0)
        {
            touchedNote = notesInRange[0];
        }
        else
        {
            touchedNote = null;
            touched = false;
        }
        
        if(touchedNote != null)
        {
            noteDistance = transform.position.y + touchedNote.transform.position.y;
        }
        
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "rightNote" || other.tag == "leftNote" || other.tag == "upNote" || other.tag == "downNote" || other.tag == "longRightNote" || other.tag == "longDownNote" || other.tag == "longUpNote")
        {
            notesInRange.Add(other.gameObject);
            touched = true;
        }
    }

    void OnTriggerExit2D(Collider2D other)
    {
        if(other.tag == "rightNote" || other.tag == "leftNote" || other.tag == "upNote" || other.tag == "downNote" || other.tag == "longRightNote" || other.tag == "longDownNote" || other.tag == "longUpNote")
        {
            notesInRange.Remove(other.gameObject);
            
        }
    }
}
