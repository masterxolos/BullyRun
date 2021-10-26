using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class PaperAirplaneDoTween : MonoBehaviour
{
    [SerializeField]
    private Transform planeTransform;

    [SerializeField]
    private Ease planeAnimEase;

    [SerializeField]
    private float animDuration;

    [SerializeField]
    private float planeDestination;
    void Start()
    {
        planeTransform.DOMoveX(planeDestination, animDuration).SetLoops(-1, LoopType.Restart).SetEase(planeAnimEase);
    }

}
