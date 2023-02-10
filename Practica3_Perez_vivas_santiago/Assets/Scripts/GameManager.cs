using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; 


public class GameManager : MonoBehaviour
{
	public static GameManager instance; //Variable estatica para crear el GameManager.
	private float punctuation = 0;//Para la puntuacion.
	private float time = 0;//Para el tiempo.
	void Awake()
	{
		if (!instance)       //if(instance == null) comprueba que instance no tiene ningun tipo de informacion.
		{
			instance = this;
			DontDestroyOnLoad(gameObject);
		}
		else
		{
			//si tiene informacion , significa que ya esiste otro GameManager.
			Destroy(gameObject);

		}
	}
	private void Update()
	{
		time += Time.deltaTime;
	}
	public void AddPunt(int value)
	{
		punctuation += value;
	}
	public float GetPunt()
	{
		return punctuation;
	}
	public float GetTime()
	{
		return time;
	}
	public void ChangeScene(string Game)
    {
		time = 0;
		punctuation = 0;
		SceneManager.LoadScene(Game);
		//AudioManager.instance.ClearAudioList();
    }
	public void ExitTheGame(string Exit)
    {
		Debug.Log("has left the game.");
    }
}
