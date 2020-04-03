using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class GameManager : MonoBehaviour {

	public float slowness = 5f;

	public GameObject Restartbutton;
	public GameObject GameOverText;
	public GameObject MainMenuButton;

	public void EndGame ()
	{
		StartCoroutine(RestartLevel());
    }

	IEnumerator RestartLevel ()
	{
		Time.timeScale = 1f / slowness;
		Time.fixedDeltaTime = Time.fixedDeltaTime / slowness;

		yield return new WaitForSeconds(1f / slowness);

		Time.timeScale = 1f;
		Time.fixedDeltaTime = Time.fixedDeltaTime * slowness;
	
		GameOverText.SetActive(true);
		Restartbutton.SetActive(true);
		MainMenuButton.SetActive(true);
	}

	public void Restart()
    {
		SceneManager.LoadScene(SceneManager.GetActiveScene().name);
	}

	public void MainMenu()
	{
		SceneManager.LoadScene("Menu", LoadSceneMode.Single);
	}
}
