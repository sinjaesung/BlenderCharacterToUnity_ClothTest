using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerCamera : MonoBehaviour
{
    Camera mainCam;

    void Awake()
    {
        mainCam = Camera.main;
    }

    private void Start()
    {
        if (mainCam != null)
        {
            // configure and make camera a child of player with 3rd person offset
            mainCam.orthographic = false;
            mainCam.transform.SetParent(transform);
            mainCam.transform.localPosition = new Vector3(0f, 3f, -8f);
            mainCam.transform.localEulerAngles = new Vector3(10f, 0f, 0f);
        }
        else
            Debug.LogWarning("PlayerCamera: Could not find a camera in scene with 'MainCamera' tag.");
    }

    private void OnDisable()
    {
        if (mainCam != null)
        {
            /*mainCam.transform.SetParent(null);
            SceneManager.MoveGameObjectToScene(mainCam.gameObject, SceneManager.GetActiveScene());
            mainCam.orthographic = true;
            mainCam.orthographicSize = 15f;
            mainCam.transform.localPosition = new Vector3(0f, 70f, 0f);
            mainCam.transform.localEulerAngles = new Vector3(90f, 0f, 0f);*/
        }
    }
}