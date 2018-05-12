using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameEventManager : MonoBehaviour {
    public delegate void ScoreEvent();
    public static event ScoreEvent ScoreChange;

    public delegate void GameoverEvent();
    public static event GameoverEvent GameoverChange;

    public delegate void FriendTouchEvent();
    public static event GameoverEvent FriendTouchChange;

    public void PlayerEscape()
    {
        if (ScoreChange != null)
        {
            ScoreChange();
        }
    }
    public void PlayerGameover()
    {
        if (GameoverChange != null)
        {
            GameoverChange();
        }
    }


    public void PlayerFriend()
    {
        if (FriendTouchChange != null)
        {
            FriendTouchChange();
        }
    }
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
