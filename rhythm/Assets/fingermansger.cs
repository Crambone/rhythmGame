using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fingermansger : MonoBehaviour
{
    public List<GameObject> fingers = new List<GameObject>();
    public GameObject finger;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        foreach(Touch touch in Input.touches)
        {
            if(touch.phase == TouchPhase.Began)
            {
                GameObject tempFinger = Instantiate(finger);
                tempFinger.GetComponent<finger1>().touchVar = touch.fingerId;
            }
            
        }
        
    }
}
