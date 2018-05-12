using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreRecorder : MonoBehaviour {
    public FirstSceneController sceneController;
    public int score = 0;
    public int to_rescue = 2;

	// Use this for initialization
	void Start () {
        sceneController = (FirstSceneController)SSDirector.GetInstance().CurrentSceneController;
        sceneController.recorder = this;//先赋值
	}
	public int GetScore()
    {
        return score;
    }
    public void AddScore()
    {
        score++;
    }
    public int GetFriendNumber()
    {
        return to_rescue;
    }
    public void ReduceFriend()
    {
        to_rescue--; 
    }
}
