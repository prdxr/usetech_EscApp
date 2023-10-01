using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloorStorage : MonoBehaviour
{
    [SerializeField] private Data _data;
    
    private Floor[] _floors;

    private void Awake()
    {
        _floors = FindObjectsOfType<Floor>();
    }

    private void Start()
    {
        _data.ChangeMainMap(GetFloorOfNumber(1).GetSprite());
    }

    public Floor[] GetListFloors()
    {
        return _floors;
    }

    public int GetCountFloors()
    {
        return _floors.Length;
    }

    public Floor GetFloorOfNumber(int numberFloor)
    {
        foreach (Floor floor in _floors)
        {
            if (floor.GetNumber() == numberFloor)
            {
                return floor;
            }
        }

        return null;
    }
}
