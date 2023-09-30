using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Data", menuName = "ScriptableObjects/SpawnManagerScriptableObject", order = 1)]
public class Data : ScriptableObject
{
     [SerializeField] private float u_ratiox;
     [SerializeField] private float u_ratioy;

     [SerializeField] private List<float[]> e_rations = new List<float[]>();

     [SerializeField] private float s_ratiox;
     [SerializeField] private float s_ratioy;

     private Sprite _mainMap;

     public void SetUserRatio(float x, float y)
     {
          u_ratiox = x;
          u_ratioy = y;
     }
     public void AddExitRatio(float x, float y)
     {
          e_rations.Add(new []{x,y});
     }
     public void SetSmokeRatio(float x, float y)
     {
          s_ratiox = x;
          s_ratioy = y;
     }

     public void ChangeMainMap(Sprite map)
     {
          _mainMap = map;
     }

     public Sprite GetSpriteMainMap()
     {
          return _mainMap;
     }
}
