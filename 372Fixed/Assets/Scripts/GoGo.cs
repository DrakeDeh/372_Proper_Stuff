using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoGo : MonoBehaviour
{
   	void OnEnable(){
   	    EventManager even = GetComponent<EventManager>();
   		even.Teleport += GoGo2;
   	
   	}
   	void OnDisable(){
   		EventManager even = GetComponent<EventManager>();
        even.Teleport -= GoGo2;
   	
   	}

    private void GoGo2(object sender, EventManager.TeleEvent e)
    {
        Vector3 pos = transform.position;
    	pos.x = 2197;
    	pos.y = 60;
    	pos.z = 2395;
    	transform.position = pos;
        //throw new NotImplementedException();
    }

    private void GoGo2(){
    	
    
    }
}
