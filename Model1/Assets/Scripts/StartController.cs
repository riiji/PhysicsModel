using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StartController : MonoBehaviour
{
    [SerializeField]
    private GameObject _M1speedSliderObject;
    [SerializeField]
    private GameObject _M1massSliderObject;
    [SerializeField]
    private GameObject _M2speedSliderObject;
    [SerializeField]
    private GameObject _M2massSliderObject;

    private Slider _M2speedSlider;
    private Slider _M1speedSlider;
    private Slider _M1massSlider;
    private Slider _M2massSlider;


    [SerializeField]
    private GameObject _sphere1;
    [SerializeField]
    private GameObject _sphere2;

    private Power _sphere1Power;
    private Power _sphere2Power;

    private ObjectMass _sphere1Mass;
    private ObjectMass _sphere2Mass;

    private Button _button;
    private 

    // Start is called before the first frame update
    void Start()
    {
        _M1speedSlider = _M1speedSliderObject.GetComponent<Slider>();
        _M1massSlider = _M1massSliderObject.GetComponent<Slider>();
        _M2speedSlider = _M2speedSliderObject.GetComponent<Slider>();
        _M2massSlider = _M2massSliderObject.GetComponent<Slider>();

        _sphere1Mass = _sphere1.GetComponent<ObjectMass>();
        _sphere2Mass = _sphere2.GetComponent<ObjectMass>();

        _sphere1Power = _sphere1.GetComponent<Power>();
        _sphere2Power = _sphere2.GetComponent<Power>();

        _button = GetComponent<Button>();
        _button.onClick.AddListener(OnClick);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnClick()
    {
        _sphere1Mass.Mass = _M1massSlider.value;
        _sphere2Mass.Mass = _M2massSlider.value;

        _sphere1Power.PowerValue = _M1speedSlider.value;
        _sphere2Power.PowerValue = _M2speedSlider.value;

        _button.enabled = false;
    }
}
