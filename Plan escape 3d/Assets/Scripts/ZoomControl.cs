using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ZoomControl : MonoBehaviour
{
    [SerializeField] private Slider _slider;
    
    private ViewFloorControlSystem _viewFloorControlSystem;
    private FloorStorage _floorStorage;

    private void Awake()
    {
        _viewFloorControlSystem = FindObjectOfType<ViewFloorControlSystem>();
        _floorStorage = FindObjectOfType<FloorStorage>();
    }

    private void Start()
    {
        _slider.value = 1;
    }

    public void SliderReactionSetZoom()
    {
        SetZoom(_slider.value);
    }

    public void ButtonReactionSetZoom(float valueScale)
    {
        _slider.value += valueScale;
        SetZoom(_slider.value + valueScale);
    }

    public void SetZoom(float valueScale)
    {
        Floor floor = _viewFloorControlSystem.GetCurrentFloor();
        floor.ChangeScale(_slider.value,_slider.value); 
    }

    public void SetZoomCommonStageFloors()
    {
        _slider.value = 1;
        foreach (Floor floor in _floorStorage.GetListFloors())
        {
            floor.ChangeScale(1,1);
        }
    }
}
