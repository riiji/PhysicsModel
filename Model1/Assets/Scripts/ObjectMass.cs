using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectMass : MonoBehaviour
{
    [SerializeField]
    private float _mass;

    public float Mass
    {
        get
        {
            return _mass;
        }
        set
        {
            _mass = value;
        }
    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
