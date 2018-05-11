using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PatrolFollowAction : SSAction {
    private float speed = 2f;
    private GameObject player;
    private PatrolData data;

    public static PatrolFollowAction GetSSAction(GameObject player)
    {
        
        PatrolFollowAction action = CreateInstance<PatrolFollowAction>();
        action.player = player;
        return action;
    }

    // Use this for initialization
    public override void Start () {
        data = this.gameobject.GetComponent<PatrolData>();
	}

    // Update is called once per frame
    public override void Update()
    {

        if (transform.localEulerAngles.x != 0 || transform.localEulerAngles.z != 0)
        {
            transform.localEulerAngles = new Vector3(0, transform.localEulerAngles.y, 0);
        }
        if (transform.position.y != 0)
        {
            transform.position = new Vector3(transform.position.x, 0, transform.position.z);
        }
    //    Debug.Log("yes");
        Follow();

    }

    void Follow()
    {
        transform.position = Vector3.MoveTowards(this.transform.position, player.transform.position, speed * Time.deltaTime);
        this.transform.LookAt(player.transform.position);
    }
}
