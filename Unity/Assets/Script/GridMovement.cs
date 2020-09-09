using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridMovement : MonoBehaviour
{
	public Transform playerTransform;
	public Vector3 fwd,bwd,lft,rgt,up,dwn;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    //The 6-directional movement	
    	if(Input.GetKeyDown(KeyCode.W)){
    		playerTransform.position += fwd;
    	}
    	if(Input.GetKeyDown(KeyCode.S)){
    		playerTransform.position += bwd;
    	}
    	if(Input.GetKeyDown(KeyCode.A)){
    		playerTransform.position += lft;
    	}
    	if(Input.GetKeyDown(KeyCode.D)){
    		playerTransform.position += rgt;	
    	}
    	if(Input.GetKeyDown(KeyCode.Q)){
    		playerTransform.position += up;	
    	}
    	if(Input.GetKeyDown(KeyCode.E)){
    		playerTransform.position += dwn;	
    	}
    //Attempted player reset if passed the playable grid
    	if(playerTransform.position.lft<0){
    		playerTransform.position += rgt;

    	}	
    }
}
