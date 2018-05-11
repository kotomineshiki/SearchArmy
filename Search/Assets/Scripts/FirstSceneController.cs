using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstSceneController : MonoBehaviour ,IUserAction, ISceneController{
    public Camera MainCamera;
    public GameFactory Factory;
    public float player_speed = 5f;
    private List<GameObject> patrols;
    public GameObject player;
    public PatrolActionManager action_manager;
    public ScoreRecorder recorder;

    void IUserAction.Burst(float x, float y)
    {
        throw new System.NotImplementedException();
    }

    int IUserAction.GetBurstCDTime()
    {
        throw new System.NotImplementedException();
    }

    int IUserAction.GetScore()
    {
        throw new System.NotImplementedException();
    }

    public void LoadResources()
    {
        patrols = Factory.GetPatrols();
        for(int i = 0; i < patrols.Count; ++i)
        {
            action_manager.GoPatrol(patrols[i]);
        }
    }

    public void Move(float x, float z)
    {
        Vector3 temp = new Vector3(x, 0, z);
        if (x != 0 || z != 0)
        {
            player.GetComponent<Animator>().SetBool("run", true);


            player.transform.LookAt(temp * 1000);
            player.transform.position = temp * player_speed * Time.deltaTime + player.transform.position;
        }
        else
        {
            player.GetComponent<Animator>().SetBool("run", false);
        }






            
            
       // if(player.transform.localEulerAngles.x!=0||)


    }
    public void BeginGame()
    {
        //throw new System.NotImplementedException();
    }
    public bool GetGameover()
    {
        //throw new System.NotImplementedException();
        return false;
    }


    // Use this for initialization
    void Start () {
        SSDirector director = SSDirector.GetInstance();
        director.CurrentSceneController = this;
        Factory = Singleton<GameFactory>.Instance;
        action_manager = gameObject.AddComponent<PatrolActionManager>() as PatrolActionManager;
        LoadResources();
        
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    public int GetScore()
    {
        return recorder.GetScore();
    }

}
