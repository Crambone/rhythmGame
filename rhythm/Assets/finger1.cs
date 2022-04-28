using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class finger1 : MonoBehaviour
{
	private Vector3 touchpos;
    public int touchVar;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        foreach(Touch touc in Input.touches)
        {
            if(touc.fingerId == touchVar)
            {
                if(touc.phase == TouchPhase.Moved || touc.phase == TouchPhase.Stationary)
                {
                    touchpos = Camera.main.ScreenToWorldPoint(touc.position);
                    transform.position = new Vector3(touchpos.x, touchpos.y, 0f);
                }
                
                if(touc.phase == TouchPhase.Ended)
                {
                    Destroy(this.gameObject);
                }
            }
        }
    }
}
