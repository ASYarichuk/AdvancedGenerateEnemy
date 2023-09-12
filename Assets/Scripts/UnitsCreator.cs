using System.Collections.Generic;
using UnityEngine;

public class UnitsCreator : MonoBehaviour
{
    [SerializeField] private Rigidbody _unit;

    private List<Rigidbody> _units = new List<Rigidbody>();

    public List<Rigidbody> Units => _units;

    public void Create()
    {
        var soldier = Instantiate(_unit, transform.position, Quaternion.identity);

        _units.Add(soldier);
    }
}
