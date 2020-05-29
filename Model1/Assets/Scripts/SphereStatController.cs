using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class SphereStatController : MonoBehaviour
{
    [SerializeField]
    private GameObject _sphere;
    private TextMeshPro _tmp;

    private Power _spherePower;
    private ObjectMass _sphereMass;

    // Start is called before the first frame update
    void Start()
    {
        _tmp = GetComponent<TextMeshPro>();

        _spherePower = _sphere.GetComponent<Power>();
        _sphereMass = _sphere.GetComponent<ObjectMass>();
    }

    // Update is called once per frame
    void Update()
    {
        _tmp.text = $"p = {Math.Round(_spherePower.PowerValue * _sphereMass.Mass, 3, MidpointRounding.AwayFromZero)}" + Environment.NewLine + $"v = {Math.Round(_spherePower.PowerValue, 3, MidpointRounding.AwayFromZero)}";
    }
}
