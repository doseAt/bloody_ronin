using UnityEngine;
using System.Collections;

public class Ronin : MonoBehaviour
{

	public static Game game;

	void Awake ()
	{
		game = GameObject.Find ("Game").GetComponent<Game> ();
	}
}
