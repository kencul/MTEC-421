using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class SliderControl : MonoBehaviour
{
    public static SliderControl Instance;

    [SerializeField] Slider VolSlider;
    [SerializeField] Slider LPFSlider;

    [SerializeField] TextMeshProUGUI VolText;
    [SerializeField] TextMeshProUGUI LPFText;

    public void Awake()
    {
        //singleton instance
        if (Instance != null && Instance != this)
            Destroy(this);
        else
            Instance = this;
    }

    public void SetVolume (float i)
    {
        VolSlider.value = i;
    }

    public void SetLPF (float i)
    {
        LPFSlider.value = i;
    }

    public void SetVolText ()
    {
        VolText.text = VolSlider.value * 100 + "%";
    }
    
    public void SetLPFText ()
    {
        LPFText.text = LPFSlider.value + " hz";
    }
}
