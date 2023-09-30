using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetCordinate : MonoBehaviour
{
    void Update()
    {
        if (Input.touchCount ==1)
        {
            DebugPosition();
        }
    }

    private void DebugPosition()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        RaycastHit2D hit = Physics2D.Raycast(ray.origin, ray.direction, Mathf.Infinity);

        if (hit != null)
        {
            Debug.Log(hit.point);
        }
    }
}
