using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Power : MonoBehaviour
{
    [SerializeField]
    private float _powerValue;
    public float OldPowerDiff;

    public float PowerValue
    {
        get
        {
            return _powerValue;
        }
        set
        {
            _powerValue = value;
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
