using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class combomanager : MonoBehaviour
{
    public GameObject pointManager;
    public float combo;
    // Start is called before the first frame update
    void Start()
    {
        this.gameObject.GetComponent<Text>().color = Color.yellow;
    }

    // Update is called once per frame
    void Update()
    {
        this.gameObject.GetComponent<Text>().text = combo.ToString() + " X";
    }

    public void comboUpdate()
    {
        combo += 1;
        this.gameObject.GetComponent<Text>().fontSize = 60;
        Invoke("resetComboSize", 0.1f);
    }

    void resetComboSize()
    {
        this.gameObject.GetComponent<Text>().fontSize = 50;
    }
}
