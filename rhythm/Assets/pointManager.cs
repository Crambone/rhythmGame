using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class pointManager : MonoBehaviour
{
    public int missCount;
    public float score;
    public float maxScore;
    public GameObject accuracyText;
    public float displayedScore;
    // Start is called before the first frame update
    void Start()
    {
        this.gameObject.GetComponent<Text>().color = Color.yellow;
        maxScore = 245000f; //calculated with maxScoreCalculator
    }

    // Update is called once per frame
    void Update()
    {
        displayedScore = Mathf.Round(score * 1000000/maxScore);
        if(displayedScore > 999999.0001f && displayedScore < 1000000f)
        {
            displayedScore = 1000000f;
        }
        this.gameObject.GetComponent<Text>().text = displayedScore.ToString();
    }

    public void miss()
    {
        missCount += 1;
        accuracyText.GetComponent<accuracyText>().missAccuracy();
        this.gameObject.GetComponent<Text>().color = Color.white;
    }

    public void scoreUpdate(float scoreAdded)
    {
        score = score + scoreAdded;
        this.gameObject.GetComponent<Text>().fontSize = 60;
        Invoke("resetScoreSize", 0.1f);
    }

    void resetScoreSize()
    {
        this.gameObject.GetComponent<Text>().fontSize = 50;
    }

}
