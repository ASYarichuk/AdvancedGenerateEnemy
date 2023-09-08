using System.Collections.Generic;
using UnityEngine;

public class Unit : MonoBehaviour
{
    [SerializeField] private Rigidbody _unit;

    [SerializeField] private Transform _target;

    private float _speed = 1f;

    private List<Rigidbody> _units = new List<Rigidbody>();

    public void Create()
    {
        var soldier = Instantiate(_unit, transform.position, Quaternion.identity);

        _units.Add(soldier);
    }

    private void Update()
    {
        if (_units != null)
        {
            foreach (Rigidbody unit in _units)
            {
                unit.transform.position = Vector3.Lerp(unit.transform.position, _target.position, _speed * Time.deltaTime);
            }
        }
    }
}
