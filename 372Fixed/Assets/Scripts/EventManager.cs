using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventManager : MonoBehaviour
{
	
	public event EventHandler<TeleEvent> Teleport;
	public class TeleEvent : EventArgs {
		public int teleCount;
	
	
	}
	private int teleCount;
	// Start is called before the first frame update
   
   public event HELP OnHELP;
   public delegate void HELP(float f);
   
   
   
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R)){
        	if (Teleport != null){
        		teleCount++;
        		Teleport(this, new TeleEvent {teleCount = teleCount});
        		
        	}
        	OnHELP?.Invoke(5.5f);
        	//Teleport?.Invoke(this, EventArgs.Empty); == shorthand
        }
    }
}
