using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameOver : MonoBehaviour {
    public FirstSceneController sceneController;
    public Text temp;
    // Use this for initialization
    void Start () {
        sceneController = (FirstSceneController)SSDirector.GetInstance().CurrentSceneController;
    }
	
	// Update is called once per frame
	void Update () {
		
	}
    private void OnTriggerEnter(Collider other)

    {
        if (other.tag == "Player")
        {
            Debug.Log("GameOver");
            Singleton<GameEventManager>.Instance.PlayerGameover();//游戏结束
            temp.text = "GameOver";
        }
    }
}
