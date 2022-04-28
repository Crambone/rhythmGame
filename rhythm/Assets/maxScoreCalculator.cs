using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class maxScoreCalculator : MonoBehaviour
{
    public float baseScore;
    public float maxScore;
    public float displayedScore;
    public float noteCount;
    public float combo;
    // Start is called before the first frame update
    void Start()
    {
        for(float f = 1; f <= noteCount; f += 1f)
        {
            combo += 1f;
            maxScore += baseScore * combo;
            
        }
        displayedScore = maxScore * 1000000/maxScore;
        Debug.Log(displayedScore);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
