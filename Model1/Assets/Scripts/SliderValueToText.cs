using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SliderValueToText : MonoBehaviour
{
    [SerializeField]
    private string _sliderName;
    private Slider _slider;
    private Text _text;
    private string _oldText;

    // Start is called before the first frame update
    void Start()
    {
        _text = GetComponent<Text>();
        _slider = GameObject.Find(_sliderName).GetComponent<Slider>();
        _oldText = _text.text;
    }

    // Update is called once per frame
    void Update()
    {
        _text.text = $"{_oldText} {_slider.value}";
    }
}
