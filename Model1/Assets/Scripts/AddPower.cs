using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

[RequireComponent(typeof(Power))]
[RequireComponent(typeof(Transform))]
public class AddPower : MonoBehaviour
{
    private Power _power;
    private Transform _transform;

    // Start is called before the first frame update
    void Start()
    {
        _transform = GetComponent<Transform>();
        _power = GetComponent<Power>();
    }

    // Update is called once per frame
    void Update()
    {
        _transform.position = _transform.position + new Vector3(_power.PowerValue * Time.deltaTime, 0, 0);
    }
}
