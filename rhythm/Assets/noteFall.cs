using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class noteFall : MonoBehaviour
{
    public float speed;
    public bool moving;
    public float editorOffset;

    public List<GameObject> notes = new List<GameObject>();
    // Start is called before the first frame update
    void Awake()
    {
        //OFFSET CAN BE SET IN THE INSPECTOR AT SONGPLAYER
        speed = 5f; //multiplier

        foreach(Transform child in transform)
        {
            notes.Add(child.gameObject);
        }

        foreach(GameObject note in notes)
        {
            Transform editortransform = note.transform;
            note.transform.localPosition = new Vector3(editortransform.position.x, editortransform.position.y * speed, editortransform.position.z);
        }
        transform.position = new Vector2(transform.position.x, -1 * editorOffset * speed);
        Invoke("move", 0f);
        
    }

    // Update is called once per frame
    void Update()
    {
        if(moving == true)
        {
            transform.position += transform.up * -1 * 1.5f * speed * Time.deltaTime;
        }
        
    }

    void move()
    {
        moving = true;
    }
}
