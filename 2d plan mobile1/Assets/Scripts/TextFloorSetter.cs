using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class TextFloorSetter : MonoBehaviour
{
    private TMP_Text _text;

    private void Awake()
    {
        _text = GetComponent<TMP_Text>();
    }

    public void ChangeTextFloor(int numberFloor)
    {
        _text.text = $"{numberFloor}";
    }
}
