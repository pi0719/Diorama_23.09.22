using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;
using UnityEngine.UI;

public class ARImageActivation : MonoBehaviour
{
    [SerializeField]
    private ARTrackedImageManager trackedImageManager;

    [SerializeField]
    private GameObject activationCanvas; // ���⼭ Canvas ����

    [SerializeField]
    private Image[] activationImages; // �̹��� �迭

    private void OnEnable()
    {
        trackedImageManager.trackedImagesChanged += OnImageChanged;
    }

    private void OnDisable()
    {
        trackedImageManager.trackedImagesChanged -= OnImageChanged;
    }

    private void OnImageChanged(ARTrackedImagesChangedEventArgs eventArgs)
    {
        foreach (var trackedImage in eventArgs.added)
        {
            UpdateActivationImage(trackedImage);
        }

        foreach (var trackedImage in eventArgs.updated)
        {
            UpdateActivationImage(trackedImage);
        }
    }

    private void UpdateActivationImage(ARTrackedImage trackedImage)
    {
        string imageName = trackedImage.referenceImage.name;

        // �̹����� �νĵǾ����ϴ� ����� �α� �߰�
        Debug.Log("�̹����� �νĵǾ����ϴ�: " + imageName);

        // Canvas Ȱ��ȭ
        activationCanvas.SetActive(true);

        // ��� �̹����� ���� ��Ȱ��ȭ
        foreach (var image in activationImages)
        {
            image.gameObject.SetActive(false);
        }

        // Ư�� �̹����� Ȱ��ȭ
        if (imageName == "AImageName") // �� �̸��� ���� �̹��� �̸��� �°� �������ּ���.
        {
            activationImages[0].gameObject.SetActive(true);
        }
        // �ٸ� �̹����鿡 ���ؼ��� ����� ������� ���� ����
    }
}
