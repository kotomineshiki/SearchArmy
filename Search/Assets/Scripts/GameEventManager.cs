using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameEventManager : MonoBehaviour {
    public delegate void ScoreEvent();
    public static event ScoreEvent ScoreChange;

    public delegate void GameoverEvent();
    public static event GameoverEvent GameoverChange;
    public delegate void CrystalEvent();
    public static event CrystalEvent CrystalChange;

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
    public void ReduceCrystalNum()
    {
        if (CrystalChange != null)
        {
            CrystalChange();
        }
    }
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
