using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddPointPosition : MonoBehaviour
{
    [SerializeField] private GameObject _gameObject;
    [SerializeField] private GameObject _parent;

    private List<GameObject> _points = new List<GameObject>();
    public void CreatePoint(Vector2 position)
    {
        _points.Add(Instantiate(_gameObject, new Vector3(position.x,position.y,0),Quaternion.identity,_parent.transform));
    }

    private void Start()
    {
        _points.Clear();
    }
}
