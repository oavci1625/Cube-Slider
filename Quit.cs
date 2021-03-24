using UnityEngine;

public class Quit : MonoBehaviour
{ 
    public void CloseApp()
    {
        Debug.Log("Quit");
        Application.Quit();
    }
}
