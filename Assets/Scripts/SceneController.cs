using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour {

	public float autoLoadNextLevelAfter;

	void Start()
	{
		if (autoLoadNextLevelAfter == 0) {
			Debug.Log ("Not autoloading");
		} else {
			Invoke ("LoadNextScene", autoLoadNextLevelAfter);
		}
	}

	public void LoadNextScene()
	{
		SceneManager.LoadScene (SceneManager.GetActiveScene().buildIndex + 1);
	}

	public void Load(string scene)
	{
		SceneManager.LoadScene (scene);
	}

	public void Quit()
	{
		Load("MenuScene");
	}

	public void Close()
	{
		Application.Quit ();
	}
}