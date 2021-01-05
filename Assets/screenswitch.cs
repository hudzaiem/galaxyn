using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class screenswitch : MonoBehaviour
{
	public void Mulai(){
		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);
	}

	public void MainMenu(){
		 SceneManager.LoadScene("shboard");
	}
	public void goCredit()
	{
		SceneManager.LoadScene("Credit");
	}
}
