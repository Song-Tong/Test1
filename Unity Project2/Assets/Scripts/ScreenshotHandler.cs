using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;


public class ScreenshotHandler : MonoBehaviour {

    private static ScreenshotHandler instance;

    private Camera myCamera;
    private bool takeScreenshotOnNextFrame;

    private int nums;

    private void Awake() {
        instance = this;
        myCamera = gameObject.GetComponent<Camera>();
        nums = 0;
    }

    private void OnPostRender() {
        if (takeScreenshotOnNextFrame) {
            takeScreenshotOnNextFrame = false;
            RenderTexture renderTexture = myCamera.targetTexture;

            Texture2D renderResult = new Texture2D(renderTexture.width, renderTexture.height, TextureFormat.ARGB32, false);
            Rect rect = new Rect(0, 0, renderTexture.width, renderTexture.height);
            renderResult.ReadPixels(rect, 0, 0);

            byte[] byteArray = renderResult.EncodeToPNG();
           // System.IO.File.WriteAllBytes(Application.dataPath  + "/images/CameraScreenshot"+ nums +".jpg", byteArray);
            File.WriteAllBytes(Application.dataPath + "//" + nums + ".jpg", byteArray);
            Debug.Log("Saved CameraScreenshot.png");

            RenderTexture.ReleaseTemporary(renderTexture);
            myCamera.targetTexture = null;

        }
    }

    private void TakeScreenshot(int width, int height) {
        myCamera.targetTexture = RenderTexture.GetTemporary(width, height, 16);
        takeScreenshotOnNextFrame = true;
        nums++;
    }

    private void CameraMoveUp() {
        myCamera.transform.Translate(new Vector3(0, 2,0));
    }

    private void CameraMoveDown() {
        myCamera.transform.Translate(new Vector3(0, -2,0));
    }

    private void CameraMoveRight() {
        myCamera.transform.Translate(new Vector3(5, 0,0));
    }
     private void CameraMoveLeft() {
        myCamera.transform.Translate(new Vector3(-5, 0,0));
    }

    public static void TakeScreenshot_Static(int width, int height) {
        instance.TakeScreenshot(width, height);
    }

    public static void CameraMoveUp_Static() {
        instance.CameraMoveUp();
    }

    public static void CameraMoveDown_Static() {
        instance.CameraMoveDown();
    }

    public static void CameraMoveRight_Static() {
        instance.CameraMoveRight();
    }

    public static void CameraMoveLeft_Static() {
        instance.CameraMoveLeft();
    }
}