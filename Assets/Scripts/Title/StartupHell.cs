using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartupHell : MonoBehaviour {

	void Update(){
        if( Input.GetKeyDown( KeyCode.Return ) )
            Debug.log( "Enter key was pressed." );

    }
}
