using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class accuracyText : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void missAccuracy()
    {
        this.gameObject.GetComponent<Text>().text = "miss";
        this.gameObject.GetComponent<Text>().fontSize = 40;
        this.gameObject.GetComponent<Text>().color = Color.red;
        Invoke("resetSize", 0.1f);
    }

    public void perfectAccuracy()
    {
        this.gameObject.GetComponent<Text>().text = "perfect";
        this.gameObject.GetComponent<Text>().fontSize = 50;
        this.gameObject.GetComponent<Text>().color = Color.yellow;
        Invoke("resetSize", 0.1f);
    }

    public void lateAccuracy()
    {
        this.gameObject.GetComponent<Text>().text = "late";
        this.gameObject.GetComponent<Text>().fontSize = 50;
        this.gameObject.GetComponent<Text>().color = Color.cyan;
        Invoke("resetSize", 0.1f);
    }

    public void earlyAccuracy()
    {
        this.gameObject.GetComponent<Text>().text = "early";
        this.gameObject.GetComponent<Text>().fontSize = 50;
        this.gameObject.GetComponent<Text>().color = Color.green;
        Invoke("resetSize", 0.1f);
    }
    public void resetSize()
    {
        this.gameObject.GetComponent<Text>().fontSize = 40;

    }
}
