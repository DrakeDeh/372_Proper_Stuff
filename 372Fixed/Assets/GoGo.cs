using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoGo : MonoBehaviour
{
   	void OnEnable(){
   	    EventManager even = GetComponent<EventManager>();
   		even.pushIT += GoGo3;
   	
   	}
   	void OnDisable(){
   		EventManager even = GetComponent<EventManager>();
   		even.pushIT -= GoGo3;
   	
   	}

    private void GoGo3(object sender, EventArgs e)
    {
        Debug.Log("AAAAAAAAAAAAAAHHHHHHHHHHHHHHHHH");
        Vector3 pos = transform.position;
        pos.x = 2197;
        pos.y = 60;
        pos.z = 2395;
        transform.position = pos;
    }

}
