using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class charracter : MonoBehaviour
{

    public Slider slider;

    public int maxHeathl = 100;
    public int currentHeathl;
    protected int dameshoogun=5;




    protected virtual void Start()
    {
        currentHeathl = maxHeathl;

    }
    public void setHeath(int heathl)
    {
        slider.value = heathl;
    }
    public void setmaxheath(int heathl)
    {
        slider.maxValue = heathl;
        slider.value = heathl;
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("bulet"))
        {
            TakeDame(dameshoogun);
        }
    }
    public void TakeDame(int dame)
    {
        currentHeathl = currentHeathl - dame;
        Debug.Log("mau cua may la" + currentHeathl);
        setHeath(currentHeathl);
    }


}
