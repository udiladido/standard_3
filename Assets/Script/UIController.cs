using System.Collections;
using System.Collections.Generic;
using UnityEngine;


// 동적으로 할당하는 방법
// 1.FindObjectOfType<>으로 UI tag 묶어서 찾는다?
// 2. 싱글톤을 활용해 직접 넣어 참조한다.
// text

public class UIController : Singleton<UIController>
{
   
    public UI ui
    {
        get { return _ui; }
        set { _ui = value; }
    }
    private UI _ui;


}
