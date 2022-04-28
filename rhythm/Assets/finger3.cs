﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class finger3 : MonoBehaviour
{
	private Vector3 touchpos;
    public int fingerid;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.touchCount > 0 )
        {
            if(Input.GetTouch(2).phase == TouchPhase.Began)
            {
                Touch touch = Input.GetTouch(2);
                fingerid = touch.fingerId;
                GetComponent<CircleCollider2D>().enabled = true;
            }
            
            touchpos = Camera.main.ScreenToWorldPoint(Input.GetTouch(2).position);

            if (Input.GetTouch(fingerid).phase == TouchPhase.Ended) 
        {
            
            GetComponent<CircleCollider2D>().enabled = false;
            fingerid = 0;

        }
        }

        

        transform.position = new Vector3(touchpos.x, touchpos.y, 0f);
    }
}
