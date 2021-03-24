using UnityEngine;
using UnityEngine.SceneManagement;
public class GameManager : MonoBehaviour
{
    public bool gameHasEnded = false;
    public float restartDelay = 1;
    public void EndGame()
    {
        if(!gameHasEnded)
        {
            gameHasEnded = true;
            Invoke("Restart", restartDelay);
        }   
    }

    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void LevelWon()
    {
        
    }
}
