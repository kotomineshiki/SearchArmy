using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollide : MonoBehaviour {

    // Use this for initialization
    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Player")
        {
            Debug.Log("CO");
            other.gameObject.GetComponent<Animator>().SetTrigger("death");
            this.GetComponent<Animator>().SetTrigger("shoot");
            Singleton<GameEventManager>.Instance.PlayerGameover();
        }
        if (other.gameObject.tag == "Enemy")
        {
            Singleton<GameEventManager>.Instance.PlayerEscape();//可以用来加分
        }
        if (other.gameObject.tag == "Friend")//遇到朋友了
        {
            Singleton<GameEventManager>.Instance.PlayerEscape();//可以加分，并且朋友需要跟随
        }
    }
}
