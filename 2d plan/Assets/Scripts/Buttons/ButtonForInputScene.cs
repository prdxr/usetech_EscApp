using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonForInputScene : MonoBehaviour
{
    [SerializeField] private Data _data;
    public void ChangeScene()
    {
        _data.ClearListExit();
        SceneManager.LoadScene("Vvod");
    }
}
