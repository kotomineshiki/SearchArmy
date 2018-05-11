using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameFactory : MonoBehaviour {
    public GameObject patrol;//巡逻兵
    private List<GameObject> used = new List<GameObject>();//正在使用的巡逻兵列表
    private Vector3[] vec = new Vector3[3];

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public List<GameObject> GetPatrols()
    {

        vec[0] = new Vector3(-8.07f, 0, 14.03f);
        vec[1] = new Vector3(-17.15f, 0, 29.77f);
        vec[2] = new Vector3(-24.79f, 0, 44.2f);
        for(int i = 0; i < 3; ++i)
        {
            patrol = Instantiate((patrol));
            patrol.transform.position = vec[i];
            patrol.GetComponent<PatrolData>().sign = i + 1;
            patrol.GetComponent<PatrolData>().start_position = vec[i];
            used.Add(patrol);
        }
        return used;
    }
    public void StopPatrol()
    {
        //切换侦察兵的动画
        for(int i = 0; i < used.Count; ++i)
        {
            used[i].gameObject.GetComponent<Animator>().SetBool("run", false);
        }
    }
}
