using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using System.Collections;
using UnityEngine.SceneManagement;

public class TapsEvents : MonoBehaviour, IPointerDownHandler {

    public UnityEvent OnSingleTap;
    public UnityEvent OnDoubleTap;


    float firstTapTime = 0f;
    float timeBetweenTaps = 0.2f;
    bool doubleTapInitialized;

    public void OnPointerDown(PointerEventData eventData)
    {
        if (!doubleTapInitialized)
        {
            Invoke("SingleTap", timeBetweenTaps);
            doubleTapInitialized = true;
            firstTapTime = Time.time;
        }
        else if (Time.time - firstTapTime < timeBetweenTaps)
        {
            CancelInvoke("SingleTap");
            DoubleTap();
        }
    }

    public void DoubleTap()
    {
        doubleTapInitialized = false;
        if(OnDoubleTap != null)
        {
            OnDoubleTap.Invoke();
        }
    }

    public void SingleTap()
    {
        doubleTapInitialized = false;

        if(OnSingleTap != null)
        {
            OnSingleTap.Invoke();
        }

        Debug.Log("Pog");

        SceneManager.LoadScene(2);
    }

    public void SingleTapLibrary()
    {
        doubleTapInitialized = false;

        if(OnSingleTap != null)
        {
            OnSingleTap.Invoke();
        }

        Debug.Log("Pog");

        SceneManager.LoadScene(3);
    }

    public void SingleTapCanteen()
    {
        doubleTapInitialized = false;

        if(OnSingleTap != null)
        {
            OnSingleTap.Invoke();
        }

        Debug.Log("Pog");

        SceneManager.LoadScene(4);
    }

    public void SingleTapClass()
    {
        doubleTapInitialized = false;

        if(OnSingleTap != null)
        {
            OnSingleTap.Invoke();
        }

        Debug.Log("Pog");

        SceneManager.LoadScene(5);
    }
}