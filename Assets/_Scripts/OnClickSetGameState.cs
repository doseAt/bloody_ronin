using UnityEngine;
using System.Collections;

public class OnClickSetGameState : MonoBehaviour
{
	public Game.GameState to;

	void OnClick ()
	{
		Ronin.game.SetState (to);
	}
}
