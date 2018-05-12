using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EyeSight : MonoBehaviour {
    public bool ch=true;
    // Use this for initialization
    void OnTriggerEnter(Collider collider)
    {

        
        if (ch&&collider.gameObject.tag == "Player")
        {
            //Debug.Log("yes");
            this.gameObject.transform.parent.GetComponent<PatrolData>().follow_player = true;
        }

    }
    void OnTriggerExit(Collider collider)
    {
        if (collider.gameObject.tag == "Player")
        {
            ch = true;
        }
    }
    /*void Update()
    {
        Ray ray = new Ray(this.transform.position, this.transform.forward);
        RaycastHit hit;
        
        if (Physics.Raycast(ray,out hit))
        {
            Debug.Log("fe");
            if (hit.collider.tag == "Player")
            {
                Debug.Log("find");
            }
        }
    }*/
}
