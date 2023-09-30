using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ViewFloorControlSystem : MonoBehaviour
{
    [SerializeField] private Button _buttonNext;
    [SerializeField] private Button _buttonPrevious;
    
    private FloorStorage _floorStorage;
    private TextFloorSetter _textFloorSetter;
    private ZoomControl _zoomControl;

    private int _currentNumberFloor;
    private int _countFloors;

    private void Awake()
    {
        _floorStorage = FindObjectOfType<FloorStorage>();
        _textFloorSetter = FindObjectOfType<TextFloorSetter>();
        _zoomControl = FindObjectOfType<ZoomControl>();
        
        _currentNumberFloor = 1;
    }

    private void Start()
    {
        _countFloors = _floorStorage.GetCountFloors();
        SetViewFloor(_currentNumberFloor);
    }
    
    public void ChangeFloor(bool isNext)
    {
        if (isNext){_currentNumberFloor++;}
        else{_currentNumberFloor--;}
        
        SetViewFloor(_currentNumberFloor);
    }

    private void SetViewFloor(int numberFloorForEnableView)
    {
        foreach (Floor floor in _floorStorage.GetListFloors())
        {
            if (numberFloorForEnableView == floor.GetNumber()){ floor.SetViewMode(true);}
            else{floor.SetViewMode(false);}
        }
        
        ControlActiveButtons();
        ZoomReset();
        _textFloorSetter.ChangeTextFloor(_currentNumberFloor);
    }

    private void ControlActiveButtons()
    {
        if (_currentNumberFloor == 1){_buttonPrevious.interactable = false;}
        else{_buttonPrevious.interactable = true;}
        
        if (_currentNumberFloor == _countFloors){_buttonNext.interactable = false;}
        else{_buttonNext.interactable = true;}
    }

    public Floor GetCurrentFloor()
    {
        return _floorStorage.GetFloorOfNumber(_currentNumberFloor);
    }

    private void ZoomReset()
    {
        _zoomControl.SetZoomCommonStageFloors();
    }
}
