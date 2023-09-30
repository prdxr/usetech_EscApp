using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InputDataSystem : MonoBehaviour
{
    [Header("Buttons")]
    
    [SerializeField] private Button _smokeButton;
    [SerializeField] private Button _applyButton;
    [SerializeField] private Button _exitButton;
    [SerializeField] private Button _positionUserButton;
    
    [Header("Data")]
    [SerializeField] private Data _data;
    
    [SerializeField] private Image _image;

    private Vector2 _currentVector2;
    private bool[] _checkInput = new bool[3];

    private void Start()
    {
        ChangeModeViewButtons(false);
        _applyButton.interactable = false;
        _image.sprite = _data.GetSpriteMainMap();
    }

    private void Update()
    {
        if (Input.GetMouseButtonUp(0))
        {
            SetPositionRaycast();
        }
    }

    private void ChangeModeViewButtons(bool isView)
    {
        _smokeButton.interactable = isView;
        _exitButton.interactable = isView;
        _positionUserButton.interactable = isView;
    }

    private void SetPositionRaycast()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit2D hit2D = Physics2D.Raycast(ray.origin, ray.direction, Mathf.Infinity);
        
        if (hit2D != null && hit2D.point!= Vector2.zero)
        {
            ChooseButton(hit2D.point);
        }
    }

    private void ChooseButton(Vector2 position)
    {
        ChangeModeViewButtons(true);
        _currentVector2 = position;
    }

    public void ReactionButton(int number)
    {
        float x = _currentVector2.x/4.73f;
        float y = _currentVector2.y/4.39f;
        Debug.Log($"{x}{y}");
        if (number==0)
        {
            _data.SetSmokeRatio(x,y);
        }
        else if (number == 1)
        {
            _data.AddExitRatio(x,y);
        }
        else if(number==2)
        {
            _data.SetUserRatio(x,y);
        }

        ChangeModeViewButtons(false);
        _checkInput[number] = true;
        
        if (_checkInput[0]&& _checkInput[1] && _checkInput[2])
        {
            _applyButton.interactable = true;
        }
    }
}
