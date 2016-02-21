using UnityEngine;
using System.Collections;

public class Gameplay : MonoBehaviour
{

	void Awake ()
	{
		Game.StateChanged += OnGameStateChanged;
	}

	public void OnGameStateChanged (Game.GameState currState)
	{
		if (currState == Game.GameState.GET_READY)
			GetReady ();
		else if (currState == Game.GameState.GAME)
			StartGame ();
		else if (currState == Game.GameState.END)
			EndGame ();
	}

	public void GetReady ()
	{
		
	}

	public void EndGame ()
	{
		
	}

	public void StartGame ()
	{
		
	}
}
