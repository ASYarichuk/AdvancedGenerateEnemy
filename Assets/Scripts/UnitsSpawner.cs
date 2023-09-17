using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnitsSpawner : MonoBehaviour
{
    private Unit[] _creator;

    private int _currentSpawn;

    private float _delay = 2f;

    private void Awake()
    {
        _creator = gameObject.GetComponentsInChildren<Unit>();
    }

    private void Start()
    {
        StartCoroutine(CreateUnit());
    }

    private IEnumerator CreateUnit()
    {
        WaitForSeconds waitTimeSpawn = new(_delay);

        while (true)
        {
            _currentSpawn = Random.Range(0, _creator.Length);

            _creator[_currentSpawn].Create();

            yield return waitTimeSpawn;
        }
    }
}
