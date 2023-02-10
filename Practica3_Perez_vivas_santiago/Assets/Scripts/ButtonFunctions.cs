using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonFunctions : MonoBehaviour
{
    public void ChangeScene(string Game)
    {
        SceneManager.LoadScene(Game);
        
    }
    public void ExitTheGame(string GameOver)
    {
        SceneManager.LoadScene(GameOver);
        Debug.Log("has left the game.");
    }
    public void GoToTheMenu(string MainMenu)
    {
        SceneManager.LoadScene(MainMenu);
    }
}
