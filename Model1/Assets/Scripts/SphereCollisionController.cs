using System.Collections;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using UnityEngine;

public class SphereCollisionController : MonoBehaviour
{
    private Power _power;
    private ObjectMass _objectMass;
    public float OldPower;

    // Start is called before the first frame update
    void Start()
    {
        _power = GetComponent<Power>();
        _objectMass = GetComponent<ObjectMass>();
    }

    // Update is called once per frame
    void Update()
    {

    }


    void OnTriggerEnter(Collider collider)
    {
        if (collider.tag == "PhysicalObject")
        {
            var collisionObjectPower = collider.gameObject.GetComponent<Power>();
            var collisionObjectMass = collider.gameObject.GetComponent<ObjectMass>();

            Debug.Log($"{collider.name} {collisionObjectPower.PowerValue}");

            var newSpeed = CalculateCollide(_power.PowerValue, _objectMass.Mass, collisionObjectPower.PowerValue + collisionObjectPower.OldPowerDiff, collisionObjectMass.Mass);

            _power.OldPowerDiff = _power.PowerValue - newSpeed;
            _power.PowerValue = newSpeed;

            //StartCoroutine(Waiter());

            /*
            var v1speed = ((_objectMass.Mass - collisionObjectMass.Mass) * _power.PowerValue) / (_objectMass.Mass + collisionObjectMass.Mass);
            var v2speed = (2 * _objectMass.Mass * _power.PowerValue) / (collisionObjectMass.Mass + _objectMass.Mass);

            _power.PowerValue = v1speed;
            collisionObjectPower.PowerValue = v2speed;
            */
        }
    }

    private void OnTriggerExit(Collider other)
    {
        _power.OldPowerDiff = 0;
    }

    IEnumerator Waiter()
    {
        yield return new WaitForSeconds(0.3f);
    }

    float CalculateCollide(float p1, float m1, float p2, float m2)
    {
        var newSpeed = (2 * p2 * m2 + p1 * (m1 - m2)) / (m1 + m2);
        return newSpeed;
    }
}
