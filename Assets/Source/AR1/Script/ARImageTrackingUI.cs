using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.XR.ARFoundation;
using TMPro;

public class ARImageTrackingUI : MonoBehaviour
{
    public ARTrackedImageManager trackedImageManager;

    private TextMeshProUGUI trackingText;

    void Start()
    {
        // ���� ������Ʈ�� TextMeshProUGUI ������Ʈ�� �����ɴϴ�.
        trackingText = GetComponent<TextMeshProUGUI>();
    }

    void OnEnable()
    {
        trackedImageManager.trackedImagesChanged += OnImageChanged;
    }

    void OnDisable()
    {
        trackedImageManager.trackedImagesChanged -= OnImageChanged;
    }

    void OnImageChanged(ARTrackedImagesChangedEventArgs eventArgs)
    {
        if (eventArgs.added.Count > 0 || eventArgs.updated.Count > 0)
        {
            // �̹����� �νĵǾ��� ��
            trackingText.gameObject.SetActive(false);
        }
        else if (eventArgs.removed.Count > 0)
        {
            // �̹��� �ν��� ������� ��
            trackingText.gameObject.SetActive(true);
        }
    }
}