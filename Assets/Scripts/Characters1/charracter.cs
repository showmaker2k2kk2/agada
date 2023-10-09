using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class charracter : MonoBehaviour
{
    public float Heath;
    public Slider slider;

   public void setHeath(int heathl)
    {
        slider.value = heathl;
    }
    public void setmaxheath(int heathl)
    {
        slider.maxValue = heathl;
        slider.value = heathl;
    }
}
