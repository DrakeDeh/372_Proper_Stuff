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
    void GoGo2(){
    	Vector3 pos = transform.position;
    	pos.x = 2197;
    	pos.y = 60;
    	pos.z = 2395;
    	transform.position = pos;
    
    }
}
