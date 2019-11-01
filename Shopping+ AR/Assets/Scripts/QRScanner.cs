/*using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;
using ZXing;
using System;
using System.Threading;
using ZXing.QrCode;
using ZXing.Common;
using TMPro; // Add the TextMesh Pro namespace to access the various functions.



//======================== [ Scanner does NOT work in Unity Editor ] ========================

[AddComponentMenu("System/QRScanner")]
public class QRScanner : MonoBehaviour
{

    private bool cameraInitialized;
    private BarcodeReader barCodeReader;

    //Output of barcode data
    public TextMeshProUGUI textUI;

    void Start()
    {
        barCodeReader = new BarcodeReader();

        //enable scanner for both orientations (landscape and portrait mode)
        barCodeReader.AutoRotate = !barCodeReader.AutoRotate;

        StartCoroutine(InitializeCamera());
    }

    private IEnumerator InitializeCamera()
    {
        // Waiting a little seem to avoid the Vuforia's crashes.
        yield return new WaitForSeconds(3.25f);

        var isFrameFormatSet = CameraDevice.Instance.SetFrameFormat(Image., true);
        Debug.Log(String.Format("FormatSet : {0}", isFrameFormatSet));

        // Force autofocus.
        var isAutoFocus = CameraDevice.Instance.SetFocusMode(CameraDevice.FocusMode.FOCUS_MODE_CONTINUOUSAUTO);
        if (!isAutoFocus)
        {
            CameraDevice.Instance.SetFocusMode(CameraDevice.FocusMode.FOCUS_MODE_NORMAL);
        }
        Debug.Log(String.Format("AutoFocus : {0}", isAutoFocus));
        cameraInitialized = true;
    }

    private void Update()
    {
        if (cameraInitialized)
        {
            
            try
            {
                
                var cameraFeed = CameraDevice.Instance.GetCameraImage(PIXEL_FORMAT.RGB888);
                
                
                if (cameraFeed == null)
                {
                    return;
                }
                var data = barCodeReader.Decode(cameraFeed.Pixels, cameraFeed.BufferWidth, cameraFeed.BufferHeight, RGBLuminanceSource.BitmapFormat.RGB24);
                
                if (data != null)
                {
                    // QRCode detected.
                    Debug.Log("Detected");
                    Debug.Log(data.Text);
                    textUI.text = "Detected:" +data.Text;
                    Handheld.Vibrate();
                    data = null;
                }
                else
                {
                    Debug.Log("No QR code detected !");
                    
                }
            }
            catch (Exception e)
            {
                Debug.LogError(e.Message);
            }
      
        }
    }
}*/

using UnityEngine;
using System;
using System.Collections;

using Vuforia;

using System.Threading;

using ZXing;
using ZXing.QrCode;
using ZXing.Common;

using TMPro; // Add the TextMesh Pro namespace to access the various functions.


[AddComponentMenu("System/VuforiaCamera")]
public class QRScanner : MonoBehaviour
{
    private bool cameraInitialized;

    private BarcodeReader barCodeReader;
    private bool isDecoding = false;

    //Output of barcode data
    public TextMeshProUGUI textUI;

    void Start()
    {
        barCodeReader = new BarcodeReader();

        //enable scanner for both orientations (landscape and portrait mode)
        barCodeReader.AutoRotate = !barCodeReader.AutoRotate;

        StartCoroutine(InitializeCamera());
    }

    private IEnumerator InitializeCamera()
    {
        // Waiting a little seem to avoid the Vuforia's crashes.
        yield return new WaitForSeconds(1.25f);

        var isFrameFormatSet = CameraDevice.Instance.SetFrameFormat(PIXEL_FORMAT.RGB888, true);
        // Debug.Log(String.Format("FormatSet : {0}", isFrameFormatSet));

        // Force autofocus.
        var isAutoFocus = CameraDevice.Instance.SetFocusMode(CameraDevice.FocusMode.FOCUS_MODE_CONTINUOUSAUTO);
        if (!isAutoFocus)
        {
            CameraDevice.Instance.SetFocusMode(CameraDevice.FocusMode.FOCUS_MODE_NORMAL);
        }
        Debug.Log(String.Format("AutoFocus : {0}", isAutoFocus));
        cameraInitialized = true;
    }

    private void Update()
    {
        if (cameraInitialized && !isDecoding)
        {
            try
            {
                var cameraFeed = CameraDevice.Instance.GetCameraImage(PIXEL_FORMAT.RGB888);

                if (cameraFeed == null)
                {
                    return;
                }
                ThreadPool.QueueUserWorkItem(new WaitCallback(DecodeQr), cameraFeed);

            }
            catch (Exception e)
            {
                Debug.LogError(e.Message);
            }
        }
    }

    private void DecodeQr(object state)
    {
        isDecoding = true;
        var cameraFeed = (Image)state;
        var data = barCodeReader.Decode(cameraFeed.Pixels, cameraFeed.BufferWidth, cameraFeed.BufferHeight, RGBLuminanceSource.BitmapFormat.RGB24);
        if (data != null)
        {
            // QRCode detected.
            textUI.text = data.Text;
            isDecoding = false;
            
        }
        else
        {
            isDecoding = false;
            Debug.Log("No QR code detected !");
        }
    }
}

