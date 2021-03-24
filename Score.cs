using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Text scoreText;
    public PlayerMovement script;
    public bool isKeyAPressed = false;
    public bool isKeyDPressed = false;

    public float score = 0;
    public float scoreChangeRate;

    // Update is called once per frame
    void Update()
    {
        isKeyAPressed = script.isKeyAPressed;
        isKeyDPressed = script.isKeyDPressed;

        if (isKeyDPressed)
        {
            score = score + (scoreChangeRate * Time.deltaTime);
        }

        if (isKeyAPressed)
        {
            score = score + (scoreChangeRate * Time.deltaTime);
        }

        scoreText.text = score.ToString("0");
    }

    public float GetScore()
    {
        return score;
    }
}
