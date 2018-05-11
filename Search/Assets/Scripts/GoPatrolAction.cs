using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoPatrolAction : SSAction {//巡逻兵的巡逻与抓捕
    
    private float pos_x, pos_z;
    private float move_length;
    private float move_speed = 1.2f;
    private bool move_sign = true;
    private int direction = 0;
    private PatrolData data;
    

    private GoPatrolAction() { }

    public static GoPatrolAction GetSSAction(Vector3 location)
    {
        GoPatrolAction action = CreateInstance<GoPatrolAction>();
        action.pos_x = location.x;
        action.pos_z = location.z;
        action.move_length = Random.Range(4, 7);
        return action;
    }
    public override void Update()
    {

        GoPatrol();
        if (data.follow_player)
        {
          //  Debug.Log("y");
            this.destroy = true;
            this.callback.SSActionEvent(this, 0, this.gameobject);//??
        }
    }
    public override void Start()
    {
        this.gameobject.GetComponent<Animator>().SetBool("run", true);//此处运行一次
        
        data = this.gameobject.GetComponent<PatrolData>();
    }
    void GoPatrol()
    {
        if (move_sign)
        {
            //switch (direction% data.PatrolRoute.Count)


            pos_x = data.PatrolRoute[direction % data.PatrolRoute.Count].x;
            pos_z = data.PatrolRoute[direction % data.PatrolRoute.Count].z;
            move_sign = false;
        }
        this.transform.LookAt(new Vector3(pos_x, 0, pos_z));
        float distance = Vector3.Distance(transform.position, new Vector3(pos_x, 0, pos_z));
        if (distance > 0.9)
        {
            transform.position = Vector3.MoveTowards(this.transform.position, new Vector3(pos_x, 0, pos_z), move_speed * Time.deltaTime);
        }
        else
        {
            direction = direction + 1;
            /*if (direction > Direction.SOUTH)
            {
                direction = Direction.EAST;
            }*/
            move_sign = true;
        }
    }

}
