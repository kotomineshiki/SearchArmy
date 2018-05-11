using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameFactory : MonoBehaviour {
    public GameObject patrol;//巡逻兵
    private List<GameObject> used = new List<GameObject>();//正在使用的巡逻兵列表
    public Vector3[] vec = new Vector3[3];

    public List<Vector3>[] routes;//写三条路径
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public List<GameObject> GetPatrols()
    {

        vec[0] = new Vector3(-8.07f, 0, 14.03f);
        vec[1] = new Vector3(-18.8f, 0, 26.9f);
        vec[2] = new Vector3(-25.61f, 0, 45f);

        routes = new List<Vector3>[3];
        routes[0] = new List<Vector3>();
        routes[1] = new List<Vector3>();
        routes[2] = new List<Vector3>();
        //   new Vector3(-18.68f, 0, 14.03f);
        //Debug.Log(routes[0]);
        routes[0].Add(new Vector3(-18.68f,0,14.03f));
        routes[0].Add(new Vector3(-18.68f, 0, 6.83f));
        routes[0].Add(new Vector3(-13.52f, 0, 6.83f));
        routes[0].Add(new Vector3(-18.68f, 0, 6.83f));
        routes[0].Add(new Vector3(-18.68f, 0, 1.28f));
        routes[0].Add(new Vector3(-8.07f, 0, 1.28f));
        routes[0].Add(new Vector3(-8.07f, 0, 14.03f));

        routes[1].Add(new Vector3(-18.9f, 0, 22.12f));
        routes[1].Add(new Vector3(-9.34f, 0, 22.12f));
        routes[1].Add(new Vector3(-9.34f, 0, 37.2f));
        routes[1].Add(new Vector3(-26.47f, 0, 37.2f));
        routes[1].Add(new Vector3(-26.47f, 0, 26.9f));
        routes[1].Add(new Vector3(-18.8f, 0, 26.9f));

        routes[2].Add(new Vector3(-11.52f, 0, 45f));
        routes[2].Add(new Vector3(-25.61f, 0, 45f));

        for (int i = 0; i < 3; ++i)
        {
            patrol = Instantiate((patrol));
            patrol.transform.position = vec[i];
            patrol.GetComponent<PatrolData>().sign = i + 1;
            patrol.GetComponent<PatrolData>().start_position = vec[i];
            patrol.GetComponent<PatrolData>().PatrolRoute = routes[i];//设立巡逻路径

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
