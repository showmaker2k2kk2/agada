using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class hero : MonoBehaviour
{
    public int maxHeathl = 100;
    public int currentHeathl;
    public charracter heathbar;

    void Start()
    {
        currentHeathl = maxHeathl;

    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.T))
        {
            TakeDame(20);
        }
    }
    void TakeDame(int dame)
    {
        currentHeathl = currentHeathl - dame;
        Debug.Log("mau cua may la" + currentHeathl);
        heathbar.setHeath(currentHeathl);
    }

}
