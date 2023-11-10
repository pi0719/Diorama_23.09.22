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
        // ARSessionOrigin�� ã�Ƽ� �Ҵ��մϴ�.
        arSessionOrigin = FindObjectOfType<ARSessionOrigin>();
        // ARSessionOrigin�� ����� ī�޶� ã���ϴ�.
        arCamera = arSessionOrigin.GetComponentInChildren<Camera>();
    }

    void Update()
    {
        // ī�޶� �ٶ󺸴� ���� ���͸� ����մϴ�.
        Vector3 directionToFace = arCamera.transform.position - transform.position;
        // Y�� ȸ���� ����Ϸ���, Y���� ������ X�� Z�� ��ġ ���̸��� ����մϴ�.
        directionToFace.y = 0;

        // LookRotation�� ����Ͽ� �ش� �������� ȸ���� Quaternion�� �����մϴ�.
        Quaternion targetRotation = Quaternion.LookRotation(directionToFace);

        // ������Ʈ�� ȸ���� targetRotation���� �����մϴ�.
        transform.rotation = targetRotation;
    }
}
