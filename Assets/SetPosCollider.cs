using System;
using System.Collections;
using System.Collections.Generic;
using Sirenix.OdinInspector;
using UnityEngine;

public enum TypePos
{
    Left,
    Right,
    Top,
    Bot
}

public class SetPosCollider : MonoBehaviour
{
    public TypePos TypePos;

    private void Start()
    {
        SetPos();
    }

    [Button]
    public void SetPos()
    {
        var transformPosition = transform.position;

        switch (TypePos)
        {
            case TypePos.Left:
                transformPosition.x = Camera.main.ScreenToWorldPoint(new Vector3(0, 0, 0)).x;
                break;
            case TypePos.Bot:
                transformPosition.y = Camera.main.ScreenToWorldPoint(new Vector3(0, 0, 0)).y;
                break;
            case TypePos.Right:
                transformPosition.x = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, 0, 0)).x;
                break;
            case TypePos.Top:
                transformPosition.y = Camera.main.ScreenToWorldPoint(new Vector3(0, Screen.height, 0)).y;
                break;
        }

        transform.position = transformPosition;
    }
}