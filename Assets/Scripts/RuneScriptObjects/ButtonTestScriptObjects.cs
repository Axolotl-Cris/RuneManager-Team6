using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonTestScriptObjects : MonoBehaviour
{
    public RuneScriptObjects runeSO;
    public Button buttonAdd;
    public Button buttonSubtract;
    void Start()
    {
        buttonAdd.onClick.AddListener(activatorAdd);
        buttonSubtract.onClick.AddListener(activatorSubtract);
    }
    public void activatorAdd()
    {
        runeSO.Added();
        Debug.Log("Name " + runeSO.name);
        Debug.Log("New Amount " + runeSO.amount);
    }
    public void activatorSubtract()
    {
        runeSO.Subtract();
        Debug.Log("Name " + runeSO.name);
        Debug.Log("New Amount for " + runeSO.amount);
    }

    void Update()
    {
        //Debug.Log("Pressed Button");
    }
}
