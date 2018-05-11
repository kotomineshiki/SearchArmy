using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UserGUI : MonoBehaviour {
    private IUserAction action;
    private bool game_start = false;
	// Use this for initialization
	void Start () {
        Debug.Log(SSDirector.GetInstance().CurrentSceneController);
        action = SSDirector.GetInstance().CurrentSceneController as IUserAction;
	}
	
	// Update is called once per frame
	void Update () {
       // Debug.Log(action);
        if (game_start
            && !action.GetGameover())
        {

            action.Move(Input.GetAxis("Horizontal"),Input.GetAxis("Vertical"));
            //if (Input.GetButtonDown("Space"))
            //{
           //     action.Burst(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
            //}

        }
	}
    private void OnGUI()
    {
        if (!game_start)
        {
            if(GUI.Button(new Rect(Screen.width / 2 - 50, Screen.width / 2 - 150, 100, 50), "start"))
            {
                game_start = true;
                action.BeginGame();
            }
        }
    }
}
