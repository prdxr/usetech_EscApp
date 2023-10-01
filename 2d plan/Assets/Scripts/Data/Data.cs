using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

[CreateAssetMenu(fileName = "Data", menuName = "ScriptableObjects/SpawnManagerScriptableObject", order = 1)]
public class Data : ScriptableObject
{
    [SerializeField] private float u_ratiox;
    [SerializeField] private float u_ratioy;

    [SerializeField] private List<float[]> e_rations = new List<float[]>();

    [SerializeField] private float s_ratiox;
    [SerializeField] private float s_ratioy;

    private string _uratio;
    private string _sratio;

    private Sprite _mainMap;

    public void SetUserRatio(float x, float y)
    {
        u_ratiox = x;
        u_ratioy = y;
        UpdateData();
    }
    public void AddExitRatio(float x, float y)
    {
        e_rations.Add(new[] { x, y });
        UpdateData();
    }
    public void SetSmokeRatio(float x, float y)
    {
        s_ratiox = x;
        s_ratioy = y;
        UpdateData();
    }

    public void ChangeMainMap(Sprite map)
    {
        _mainMap = map;
        UpdateData();
    }

    public Sprite GetSpriteMainMap()
    {
        return _mainMap;
    }

    public void UpdateTheGivenText(string path)
    {
        string[] arrayS = File.ReadAllLines(path);
        for (int i = 0; i < arrayS.Length; i++)
        {
            arrayS[i] = ".";
        }
        arrayS[0] = _uratio;
        arrayS[1] = _sratio;
        for (int i = 2; i < arrayS.Length; i++)
        {
            Debug.Log("ok1");
            if (i>=e_rations.Count+2)
            {
                break;
            }
            Debug.Log("ok2");
            arrayS[i] = $"{e_rations[i - 2][0]}-{e_rations[i - 2][1]}";
        }
        Debug.Log(arrayS[3]);
        File.WriteAllLines(path, arrayS);
    }

    private void UpdateData()
    {
        _uratio = $"{u_ratiox}-{u_ratioy}";
        _sratio = $"{s_ratiox}-{s_ratioy}";
    }

    public void ClearListExit()
    {
        e_rations.Clear();
    }
}
