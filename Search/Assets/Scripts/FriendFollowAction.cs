using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FriendFollowAction : MonoBehaviour
{
    private float speed = 3f;
    public GameObject player;
    public bool followStatus=false;
    public FirstSceneController sceneController;
    // Use this for initialization
    void Awake()
    {
        sceneController = (FirstSceneController)SSDirector.GetInstance().CurrentSceneController;

    }

    // Update is called once per frame
    void Update()
    {

        //    Debug.Log("yes");

        if(followStatus)Follow();

    }

    void Follow()
    {
        transform.position = Vector3.MoveTowards(this.transform.position, player.transform.position, speed * Time.deltaTime);
        this.transform.LookAt(player.transform.position);
    }
    void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "Player")
        {
            followStatus = true;
            Singleton<GameEventManager>.Instance.PlayerFriend();
        }
        if (collision.collider.tag == "Enemy")
        {
            followStatus = false;
        }
    }
}
