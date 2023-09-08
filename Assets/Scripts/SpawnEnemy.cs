using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemy : MonoBehaviour
{
    [SerializeField] private List<Unit> _spawns = new();

    private int _currentSpawn;

    private float _timeSpawn = 2f;

    private void Awake()
    {
        foreach (Transform child in transform)
        {
            _spawns.Add(child.gameObject.GetComponent<Unit>());
        }
    }

    private void Start()
    {
        StartCoroutine(CreateUnit());
    }

    private IEnumerator CreateUnit()
    {
        WaitForSeconds waitTimeSpawn = new(_timeSpawn);

        while (true)
        {
            _currentSpawn = Random.Range(0, _spawns.Count);

            _spawns[_currentSpawn].Create();

            yield return waitTimeSpawn;
        }
    }
}
