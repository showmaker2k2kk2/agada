using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Navmeshtest : MonoBehaviour
{
    public Transform positionspam;
    
    void Start()
    {
        
    }
// 
    void Update()
    {
    //    if(Input.GetMouseButtonDown(0))
    //    {
    //        Ray ray =Camera.main.ScreenPointToRay(Input.mousePosition)
                
    //    }    
    }
    void spamRay()
    {
        Ray ray = new Ray(positionspam.position, transform.forward);
        RaycastHit hit;
        if(Physics.Raycast(ray,out hit))
        {
         
        }    
    }    
}
