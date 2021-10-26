using System.Collections;
using System.Collections.Generic;
using Unity.Collections;
using UnityEngine;

public class GameSettings : MonoBehaviour
{
    private static GameSettings _instance;
    [SerializeField, ReadOnly] private float _movementSpeed;
    [SerializeField, ReadOnly] private float _controlSpeed;
    [SerializeField, ReadOnly] private Vector3 _Offset;
    
    

    public Vector3 Offset
    {
        get { return _Offset; }
        set { _Offset = value; }
    }


    public float ControlSpeed
    {
        get { return _controlSpeed; }
        set { _controlSpeed = value; }
    }

    public float MovementSpeed
    {
        get { return _movementSpeed; }
        set { _movementSpeed = value; }
    }

    public static GameSettings Instance()
    {
        if (_instance == null)
        {
            _instance = GameObject.FindObjectOfType<GameSettings>();
        }
        return _instance;
    }
}
