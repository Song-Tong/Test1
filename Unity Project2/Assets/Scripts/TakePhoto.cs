using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TakePhoto : MonoBehaviour
{
    // Start is called before the first frame update


    [SerializeField]
    private int Ratio1=1024;

    [SerializeField]
    private int Ratio2=768;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void TakeImage()
    {
        ScreenshotHandler.TakeScreenshot_Static(Ratio1, Ratio2);
    }
}
