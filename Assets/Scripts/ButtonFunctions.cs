using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonFunctions : MonoBehaviour
{
    public void ChangeScene(string Game)
    {
        GameManager.instance.ChangeScene(Game);
        
    }
    public void ExitTheGame(string GameOver)
    {
        GameManager.instance.ChangeScene(GameOver);
        Debug.Log("has left the game.");
    }
    public void GoToTheMenu(string MainMenu)
    {
        GameManager.instance.ChangeScene(MainMenu);
    }
}
