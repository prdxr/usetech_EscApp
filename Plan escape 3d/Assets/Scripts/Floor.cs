using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Floor : MonoBehaviour
{
    [SerializeField] private int _numberFloor;

    public int GetNumber()
    {
        return _numberFloor;
    }

    public void SetViewMode(bool IsView)
    {
        foreach (Transform childrens in transform)
        {
            childrens.gameObject.SetActive(IsView);
        }        
    }

    public void ChangeScale(float scaleX,float scaleY)
    {
        transform.localScale = new Vector3(scaleX,scaleY,1);
    }
}
