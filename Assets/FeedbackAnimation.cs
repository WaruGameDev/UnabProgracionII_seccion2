using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class FeedbackAnimation : MonoBehaviour
{
    Tween shake;
    public Vector3 strenghtAnimation;
    private void Start()
    {
        shake = transform.DOShakeScale(0.5f, strenghtAnimation).Pause().SetAutoKill(false);
    }

    public void DoShake()
    {
        shake.Restart();
    }

}
