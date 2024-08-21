using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ResolutionManger : Singleton<ResolutionManger>
{
    [SerializeField]  private Camera mainCam;
    [SerializeField] private Canvas canvas;
    [SerializeField] private CanvasScaler canvasScaler;

    private Vector2 fixedAspectRotio = new Vector2(9, 16);
    protected override void DoAwake()
    {
        base.DoAwake();
        ApplySetting();
    }

    private void ApplySetting()
    {
        if(mainCam == null)
        {
            mainCam = Camera.main;
        }
        if (canvas == null)
            canvas = FindObjectOfType<Canvas>();
        if (canvasScaler == null)
            canvasScaler = FindObjectOfType<CanvasScaler>();
        if(mainCam != null)
        {
            SetCameraAspectRotio();
        }
        if (canvas != null && canvasScaler != null)
        {
            ConfigureCanvas();
        }
    }
    private void SetCameraAspectRotio()
    {
        Rect rt = mainCam.rect;
        float ScreenAspect = (float)(Screen.width / Screen.height);
        float targetAspect = fixedAspectRotio.x / fixedAspectRotio.y;

        if(ScreenAspect >= targetAspect)
        {
            float width = targetAspect / ScreenAspect;
            rt.width = (1f - width) / 2f;
            rt.height = 1f;
            rt.x = (1f - width) / 2f;
            rt.y = 0f;
        }
        else
        {
            float height = ScreenAspect / targetAspect;
            rt.width = 1f;
            rt.height = height;
            rt.x = 0f;
            rt.y = (1f - height) / 2f;
        }
        mainCam.rect = rt;
    }

    private void ConfigureCanvas()
    {
        canvas.renderMode = RenderMode.ScreenSpaceCamera;
        canvas.worldCamera = mainCam;
        canvas.planeDistance = 1f;

        canvasScaler.uiScaleMode = CanvasScaler.ScaleMode.ScaleWithScreenSize;
        canvasScaler.referenceResolution = new Vector2(1920, 1080);
        canvasScaler.screenMatchMode = CanvasScaler.ScreenMatchMode.MatchWidthOrHeight;
        canvasScaler.matchWidthOrHeight = 0.5f;
    }
}
