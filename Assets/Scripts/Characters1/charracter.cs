using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class charracter : MonoBehaviour, ITakadame
{

    public Slider slider;

    public int maxHeathl = 100;
    public int currentHeathl;
   




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
            TakeDame(5);
        }
    }
    public void TakeDame(int dame)
    {
        currentHeathl = currentHeathl - dame;
        Debug.Log("mau cua may la" + currentHeathl);
        setHeath(currentHeathl);
    }

}
