using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneOrienScript : MonoBehaviour
{
    void Start()
    {
        if (SceneManager.GetActiveScene().name == "MainMenu")
        {
            Screen.orientation = ScreenOrientation.Portrait;
            Debug.Log("This is MainMenu Scene");
        }
        else
        {
            Screen.orientation = ScreenOrientation.LandscapeLeft;
            Debug.Log("This is AR/VR Scene");
        }
    }
}
