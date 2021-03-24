using UnityEngine;

public class EndTrigger : MonoBehaviour
{
    public GameManager gameManager;
    public GameObject completeLevelUI;
    public Score score;

    private void OnTriggerEnter()
    {  
        completeLevelUI.SetActive(true);
        gameManager.LevelWon();
        PlayerPrefs.SetFloat("Score", PlayerPrefs.GetFloat("Score" , 0) + score.GetScore());
    }
}
