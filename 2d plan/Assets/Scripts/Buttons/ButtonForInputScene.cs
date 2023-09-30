using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonForInputScene : MonoBehaviour
{
    public void ChangeScene()
    {
        SceneManager.LoadScene("Vvod");
    }
}
