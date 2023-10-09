using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class hero :charracter
{
   
    private charracter heathbar;

    protected override void Start()
    {
     
        base.Start();
    }

   
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.T))
        {
            heathbar.TakeDame(20);
        }
    }

      

}
