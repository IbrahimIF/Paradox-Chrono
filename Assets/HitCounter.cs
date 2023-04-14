using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitCounter : MonoBehaviour
{
    int score = 0;
    int hits = 0;//global variable
    
    private void OnCollisionEnter(Collision other)
    {
        //score = score + 1;
        Debug.Log("Bumbed into wall" +" "+ "you now have this many hits" + "=" + hits);

        hits++;
    
        
        
        //if score = 4
            //exit();

        
        

    }
}
