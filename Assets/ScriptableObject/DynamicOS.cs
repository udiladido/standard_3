using UnityEngine;


[CreateAssetMenu(fileName = "DynamicCreateTest", menuName = "ScriptableObject")]
public class DynamicOS : ScriptableObject
{

    public string ObjectName = "Test";

    public GameObject CreateObject()
    { 
        GameObject newObject = new GameObject();

        newObject.name = ObjectName;

        return newObject;
    }


}
