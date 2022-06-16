using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void RenderMenu ()
    {
        SceneManager.LoadScene(0);
    }

    public void RenderAR ()
    {
        SceneManager.LoadScene(1);
    }

    public void RenderVR ()
    {
        SceneManager.LoadScene(2);
    }

    public void RenderVRLibrary()
    {
       SceneManager.LoadScene(3);
    }

    public void RenderVRCanteen()
    {
       SceneManager.LoadScene(4);
    }

    public void RenderVRClass()
    {
       SceneManager.LoadScene(5);
    }
}
