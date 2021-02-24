using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class GameSettings : MonoBehaviour
{
    public Slider slider;
    public Text valueCount;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        valueCount.text = slider.value.ToString();
        AudioListener.volume = slider.value;
    }
}
