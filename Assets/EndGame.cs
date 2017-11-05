using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class EndGame : MonoBehaviour {

	void OnCollisionEnter(Collision col)
	{
		SceneManager.LoadScene ("Scene2");
	}
}
