using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class Enemy : MonoBehaviour
{
    public List<GameObject> shapesEnemy;
    public enum TIPO_DE_GIRO
    {
        DERECHA, IZQUIERDA, ADELANTE, ATRAS
    }
    public TIPO_DE_GIRO tipoDeGiro;
    public enum SHAPES
    {
        CUBO, SPHERE , CAPSULE
    }
    public SHAPES shapes = SHAPES.CUBO;

    public void SelectShape(int shape)
    {
        foreach(GameObject s in shapesEnemy)
        {
            s.SetActive(false);
        }
        shapesEnemy[shape].SetActive(true);
    }
    private void Start()
    {
        SelectShape((int)shapes);
        switch(tipoDeGiro)
        {
            case TIPO_DE_GIRO.ADELANTE:
                transform.DORotate(Vector3.right * 360, 1, RotateMode.FastBeyond360).SetLoops(-1).SetEase(Ease.Linear);
                break;
            case TIPO_DE_GIRO.ATRAS:
                transform.DORotate(Vector3.right * -360, 1, RotateMode.FastBeyond360).SetLoops(-1).SetEase(Ease.Linear);
                break;
            case TIPO_DE_GIRO.DERECHA:
                transform.DORotate(Vector3.up * 360, 1, RotateMode.FastBeyond360).SetLoops(-1).SetEase(Ease.Linear);
                break;
            case TIPO_DE_GIRO.IZQUIERDA:
                transform.DORotate(Vector3.up * -360, 1, RotateMode.FastBeyond360).SetLoops(-1).SetEase(Ease.Linear);
                break;
        }
    }
}
