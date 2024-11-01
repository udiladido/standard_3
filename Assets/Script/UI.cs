using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UI : MonoBehaviour
{

    public void Awake()
    {

        UIController.Instance.ui = this;

    }

    public void ToggleCursor()
    {

        Cursor.lockState = CursorLockMode.None;


    }

}
