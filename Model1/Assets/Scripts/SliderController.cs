using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SliderController : MonoBehaviour
{
    [SerializeField]
    private AddPower _sphere;
    // Start is called before the first frame update
    void Start()
    {
        _sphere = GetComponent<AddPower>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
