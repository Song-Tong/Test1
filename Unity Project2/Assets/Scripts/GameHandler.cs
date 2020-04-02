using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameHandler : MonoBehaviour {

    private void Start() {
    }

    private void Update() {
        if (Input.GetKeyDown(KeyCode.Space)) {
            ScreenshotHandler.TakeScreenshot_Static(1024, 768);
        }

        //if (Input.GetKeyDown(KeyCode.UpArrow)) {
        //    ScreenshotHandler.CameraMoveUp_Static();
        //}
        //if (Input.GetKeyDown(KeyCode.DownArrow)) {
        //    ScreenshotHandler.CameraMoveDown_Static();
        //}
        //if (Input.GetKeyDown(KeyCode.RightArrow)) {
        //    ScreenshotHandler.CameraMoveRight_Static();
        //}
        //if (Input.GetKeyDown(KeyCode.LeftArrow)) {
        //    ScreenshotHandler.CameraMoveLeft_Static();
        //}
    }
    

   
}
