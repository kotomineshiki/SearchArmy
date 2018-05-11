using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PatrolData : MonoBehaviour {
    public int sign;
    public bool follow_player = true;
    public GameObject player;
    public Vector3 start_position;

    public List<Vector3> PatrolRoute;//巡逻路线
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
