using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIController : Singleton<UIController>
{
   
    public UI ui
    {
        get { return _ui; }
        set { _ui = value; }
    }
    private UI _ui;


}
