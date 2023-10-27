using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;

public class Canvas_Button_naviControl : MonoBehaviour
{
    public ARTrackedImageManager trackedImageManager; // AR �̹��� ������ ����
    public GameObject trackedImagePrefab; // �νĵ� �̹����� ǥ���ϴ� ������

    public GameObject Canvas_Button_navi; // AR���� ������ ������ (������ 4���� ���� 4���� ���Ե� ������Ʈ)
    public GameObject Canvas_Main; // Main ĵ����

    private GameObject spawnedObject; // �νĵ� �̹����� ǥ���ϴ� ������Ʈ

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
            Canvas_Button_navi.SetActive(true); // �������� �����ݴϴ�.
            Canvas_Button_navi.transform.SetParent(spawnedObject.transform); // �νĵ� �̹����� �ڽ����� ����
            Canvas_Button_navi.transform.localPosition = Vector3.zero; // ���� ��ġ �ʱ�ȭ
            Canvas_Button_navi.transform.localRotation = Quaternion.identity; // ���� ȸ�� �ʱ�ȭ
        }

        if (Canvas_Main)
            Canvas_Main.SetActive(false); // Main ĵ������ ����ϴ�.
    }
}