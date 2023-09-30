using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonForMainScene : MonoBehaviour
{
    public void ChangeScene()
    {
        SceneManager.LoadScene("2d");
    }
}
