using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonForMainScene : MonoBehaviour
{
    [SerializeField] private Data _data;
    public void ChangeScene()
    {
        _data.UpdateTheGivenText("D:/Gitfolder/2d plan/Data.txt");
        SceneManager.LoadScene("2d");
    }
}
