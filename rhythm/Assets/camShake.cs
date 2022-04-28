using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camShake : MonoBehaviour
{
    public GameObject cam;
    public bool effectdone;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.y <= 0 && effectdone == false)
        {
            cam.GetComponent<cameraEffects>().cameraShake();
            Destroy(this.gameObject);
            effectdone = true;
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "destroy")
        {
            Destroy(this.gameObject);
        }
    }
}
