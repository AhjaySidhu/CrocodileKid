using UnityEngine;
using System.Collections;

public class MainMenu : MonoBehaviour {

	public void Quit() {
		Application.Quit ();
	}
	
	public void StartGame() {
		Application.LoadLevel (1);
	}

	public void MainMenuReturn() {
		Application.LoadLevel (0);
	}

	public void Controls() {
		Application.LoadLevel (3);
	}

	public void Credits() {
		Application.LoadLevel (4);
	}
}
