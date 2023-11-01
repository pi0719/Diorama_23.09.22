using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AdjustRotation : MonoBehaviour
{
    void Start()
    {
        transform.rotation = Quaternion.Euler(90, 0, 0); // X축에서 90도 회전
    }
}
