using System.Collections;
using System.Collections.Generic;
using UnityEngine;


// �������� �Ҵ��ϴ� ���
// 1.FindObjectOfType<>���� UI tag ��� ã�´�?
// 2. �̱����� Ȱ���� ���� �־� �����Ѵ�.
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
