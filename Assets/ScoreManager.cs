using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public Text scoreValueText;
    public float scoreValue = 0f;
    public float pointIncreasedPerSecond = 5f;

    void FixedUpdate ()
    { 
        scoreValueText.text = ((int)scoreValue).ToString();
        scoreValue += pointIncreasedPerSecond * Time.fixedDeltaTime;
        Debug.Log(scoreValue);
    }
}
