using System.Collections;
using System.Collections.Generic;
using UnityEngine;


    public class RuneDisplay : MonoBehaviour
    {
        public RuneScriptObjects runeSO;
        void Start()
        {
            runeSO.PrintTest();
            //Debug.Log(runeSO.name);
        }
    }
