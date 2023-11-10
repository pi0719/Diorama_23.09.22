using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;
using UnityEngine.XR.ARSubsystems;


public class ObjectTouch : MonoBehaviour
{
    public Canvas canvasToShow; // 활성화할 캔버스를 인스펙터에서 할당합니다.
    private Camera arCamera; // AR 카메라를 참조합니다.

    void Start()
    {
        // AR 카메라를 찾아 참조합니다.
        arCamera = FindObjectOfType<ARSessionOrigin>().camera;
    }

    void Update()
    {
        // 화면이 터치되었는지 확인합니다.
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);

            // 첫 번째 터치가 시작되었는지 확인합니다.
            if (touch.phase == TouchPhase.Began)
            {
                // 터치된 위치에서 레이를 발사합니다.
                Ray ray = arCamera.ScreenPointToRay(touch.position);
                RaycastHit hit;

                // 레이가 오브젝트의 Collider와 충돌하는지 확인합니다.
                if (Physics.Raycast(ray, out hit))
                {
                    // 충돌한 오브젝트가 활성화되어 있고, 우리가 원하는 오브젝트인지 확인합니다.
                    if (hit.collider.gameObject == gameObject && gameObject.activeInHierarchy && IsObjectVisible(arCamera, hit.collider))
                    {
                        // 캔버스를 활성화합니다.
                        canvasToShow.gameObject.SetActive(true);
                    }
                }
            }
        }
    }

    // 오브젝트가 카메라에 보이는지 확인하는 함수입니다.
    bool IsObjectVisible(Camera cam, Collider collider)
    {
        Plane[] planes = GeometryUtility.CalculateFrustumPlanes(cam);
        return GeometryUtility.TestPlanesAABB(planes, collider.bounds);
    }
}
