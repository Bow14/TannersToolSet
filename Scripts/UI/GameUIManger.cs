using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameUIManger : MonoBehaviour
{

	public bool gameEnded;

	public GameObject gameEndedUI;

	public void GameOver()
	{
		gameEndedUI.SetActive(true);
	}
	// Use this for initialization

	public float restartDeylay = 1f;
	// Update is called once per frame
	public void DeathScreen()
	{
		if (gameEnded == false)
		{
			gameEnded = true;
			Debug.Log("Game Over");
			
			Invoke("Restart", restartDeylay);
		}
	}

	private void Restart()
	{
		SceneManager.LoadScene(SceneManager.GetActiveScene().name);
	}
}
