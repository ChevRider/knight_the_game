using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public static int score;
    private Text scoreText;

    // Start is called before the first frame update
    void Start()
    {
        scoreText = GetComponent<Text>();
        score = 0;
        scoreText.text = score.ToString();
    }

    private void Update()
    {
        scoreText.text = score.ToString();
        scoreText.text = score.ToString();
    }
}
