using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class AddMenu
{
    [MenuItem("AzeS/Import Ez Input")]
    public static void addAc()
    {
        if (GameObject.Find("EZ-Input") == null)
        {
            GameObject g = new GameObject("EZ-Input");
            g.AddComponent<EZ>();
            g.transform.SetAsFirstSibling();
        }
        else Debug.LogError("EZ-Inputs is Aktive");
    }

    

}

