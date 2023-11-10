using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;
using UnityEngine.XR.ARSubsystems;


public class ObjectTouch : MonoBehaviour
{
    public Canvas canvasToShow; // Ȱ��ȭ�� ĵ������ �ν����Ϳ��� �Ҵ��մϴ�.
    private Camera arCamera; // AR ī�޶� �����մϴ�.

    void Start()
    {
        // AR ī�޶� ã�� �����մϴ�.
        arCamera = FindObjectOfType<ARSessionOrigin>().camera;
    }

    void Update()
    {
        // ȭ���� ��ġ�Ǿ����� Ȯ���մϴ�.
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);

            // ù ��° ��ġ�� ���۵Ǿ����� Ȯ���մϴ�.
            if (touch.phase == TouchPhase.Began)
            {
                // ��ġ�� ��ġ���� ���̸� �߻��մϴ�.
                Ray ray = arCamera.ScreenPointToRay(touch.position);
                RaycastHit hit;

                // ���̰� ������Ʈ�� Collider�� �浹�ϴ��� Ȯ���մϴ�.
                if (Physics.Raycast(ray, out hit))
                {
                    // �浹�� ������Ʈ�� Ȱ��ȭ�Ǿ� �ְ�, �츮�� ���ϴ� ������Ʈ���� Ȯ���մϴ�.
                    if (hit.collider.gameObject == gameObject && gameObject.activeInHierarchy && IsObjectVisible(arCamera, hit.collider))
                    {
                        // ĵ������ Ȱ��ȭ�մϴ�.
                        canvasToShow.gameObject.SetActive(true);
                    }
                }
            }
        }
    }

    // ������Ʈ�� ī�޶� ���̴��� Ȯ���ϴ� �Լ��Դϴ�.
    bool IsObjectVisible(Camera cam, Collider collider)
    {
        Plane[] planes = GeometryUtility.CalculateFrustumPlanes(cam);
        return GeometryUtility.TestPlanesAABB(planes, collider.bounds);
    }
}
