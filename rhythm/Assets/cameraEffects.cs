using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraEffects : MonoBehaviour
{
    public float shaketime;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (shaketime > 0f)
        {
            transform.localPosition = transform.position + Random.insideUnitSphere * 0.35f;

            shaketime -= Time.deltaTime * 0.5f;
        }
        else
        {
            transform.localPosition = new Vector3(0f, -1f, -10f);
        }
    }

    public void cameraShake()
    {
        shaketime = 0.075f;
    }
}
