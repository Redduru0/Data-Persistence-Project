using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UserName : MonoBehaviour
{
    public static UserName Instance;
    public void Awake()
    {
        if(Instance != null)
        {
            Destroy(gameObject);
        }
        else
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
    }
}
