using System.Collections.Generic;
using UnityEngine;

public class UnitMover : MonoBehaviour
{
    [SerializeField] private UnitsCreator _unitsCreator;

    [SerializeField] private Transform _target;

    private float _speed = 1f;

    private void Update()
    {
        if (_unitsCreator.Units != null)
        {
            foreach (Rigidbody unit in _unitsCreator.Units)
            {
                unit.transform.position = Vector3.Lerp(unit.transform.position, _target.position, _speed * Time.deltaTime);
            }
        }
    }
}
