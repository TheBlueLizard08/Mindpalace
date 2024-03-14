using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DontDestroy : MonoBehaviour
{
    public GameObject permanentObject;
    void Awake()
    {
        DontDestroyOnLoad(permanentObject);
    }
}
