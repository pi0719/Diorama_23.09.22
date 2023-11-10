using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;

public class LookAtCamera : MonoBehaviour
{
    private ARSessionOrigin arSessionOrigin;
    private Camera arCamera;

    void Start()
    {
        // ARSessionOrigin을 찾아서 할당합니다.
        arSessionOrigin = FindObjectOfType<ARSessionOrigin>();
        // ARSessionOrigin에 연결된 카메라를 찾습니다.
        arCamera = arSessionOrigin.GetComponentInChildren<Camera>();
    }

    void Update()
    {
        // 카메라를 바라보는 방향 벡터를 계산합니다.
        Vector3 directionToFace = arCamera.transform.position - transform.position;
        // Y축 회전만 고려하려면, Y축을 제외한 X와 Z의 위치 차이만을 사용합니다.
        directionToFace.y = 0;

        // LookRotation을 사용하여 해당 방향으로 회전할 Quaternion을 생성합니다.
        Quaternion targetRotation = Quaternion.LookRotation(directionToFace);

        // 오브젝트의 회전을 targetRotation으로 설정합니다.
        transform.rotation = targetRotation;
    }
}
