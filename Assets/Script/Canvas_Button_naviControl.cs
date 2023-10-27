using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;

public class Canvas_Button_naviControl : MonoBehaviour
{
    public ARTrackedImageManager trackedImageManager; // AR 이미지 관리자 참조
    public GameObject trackedImagePrefab; // 인식된 이미지를 표시하는 프리팹

    public GameObject Canvas_Button_navi; // AR에서 보여줄 콘텐츠 (아이콘 4개와 영상 4개가 포함된 오브젝트)
    public GameObject Canvas_Main; // Main 캔버스

    private GameObject spawnedObject; // 인식된 이미지를 표시하는 오브젝트

    private void OnEnable()
    {
        trackedImageManager.trackedImagesChanged += OnTrackedImagesChanged;
    }

    private void OnDisable()
    {
        trackedImageManager.trackedImagesChanged -= OnTrackedImagesChanged;
    }

    private void OnTrackedImagesChanged(ARTrackedImagesChangedEventArgs eventArgs)
    {
        foreach (var trackedImage in eventArgs.added)
        {
            if (spawnedObject == null)
            {
                spawnedObject = Instantiate(trackedImagePrefab, trackedImage.transform.position, trackedImage.transform.rotation, trackedImage.transform);
            }
            else
            {
                spawnedObject.transform.SetPositionAndRotation(trackedImage.transform.position, trackedImage.transform.rotation);
            }
        }
    }

    public void ShowNaviContent()
    {
        if (Canvas_Button_navi)
        {
            Canvas_Button_navi.SetActive(true); // 콘텐츠를 보여줍니다.
            Canvas_Button_navi.transform.SetParent(spawnedObject.transform); // 인식된 이미지의 자식으로 설정
            Canvas_Button_navi.transform.localPosition = Vector3.zero; // 로컬 위치 초기화
            Canvas_Button_navi.transform.localRotation = Quaternion.identity; // 로컬 회전 초기화
        }

        if (Canvas_Main)
            Canvas_Main.SetActive(false); // Main 캔버스를 숨깁니다.
    }
}