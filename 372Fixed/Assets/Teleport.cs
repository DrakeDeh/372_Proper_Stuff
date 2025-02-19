using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport : MonoBehaviour
{
	
    // Start is called before the first frame update
    private void Start()
    {
        EventManager mana = GetComponent<EventManager>();
        mana.Teleport += EventManager_Teleport;
        mana.OnHELP += More_HELP;
    }
    
    private void More_HELP (float f){
    	Debug.Log("AAAHHHHH Float" + f);
    }
    
    private void EventManager_Teleport(object sender, EventManager.TeleEvent e){
    	Debug.Log("Are you moving? " + e.teleCount);
    	
    	Vector3 pos = transform.position;
    	pos.x = 2197;
    	pos.y = 60;
    	pos.z = 2395;
    	transform.position = pos;
    	
    	//EventManager mana = GetComponent<EventManager>();
    	//mana.Teleport -= EventManager_Teleport;
    	
    }
    
   

    // Update is called once per frame
    void Update()
    {
       
    }
}
