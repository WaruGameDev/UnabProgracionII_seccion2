using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CapsuleManager : MonoBehaviour
{
    public static CapsuleManager instance;
    public System.Action onCallallCapsulesSuscribed;

    private void Awake()
    {
        instance = this;
    }

    public void CallAllCapsules()
    {
        onCallallCapsulesSuscribed?.Invoke();
    }
    
}
