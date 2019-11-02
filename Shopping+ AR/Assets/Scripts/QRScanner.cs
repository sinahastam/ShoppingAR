using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;
using ZXing;
using System;
using TMPro; // Add the TextMesh Pro namespace to access the various functions.


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
        //barCodeReader.AutoRotate = !barCodeReader.AutoRotate;    //Too laggy

        //Add barcode formats to scan for | less formats = more speed
        IList<BarcodeFormat> possibleFormatisList = new List<BarcodeFormat>();
        possibleFormatisList.Add(BarcodeFormat.CODE_128);
        possibleFormatisList.Add(BarcodeFormat.QR_CODE);
        possibleFormatisList.Add(BarcodeFormat.EAN_13);
        possibleFormatisList.Add(BarcodeFormat.EAN_8);
        barCodeReader.Options.PossibleFormats = possibleFormatisList;

        StartCoroutine(InitializeCamera());

        //Repeat Scan every repeatRate
        InvokeRepeating("Decode", 1.5f, 1.5f);
    }

    private IEnumerator InitializeCamera()
    {
        // Waiting a little seem to avoid the Vuforia's crashes.
        yield return new WaitForSeconds(1.25f);

#if UNITY_EDITOR
        var isFrameFormatSet = CameraDevice.Instance.SetFrameFormat(PIXEL_FORMAT.GRAYSCALE, true);
        Debug.Log("EDITOR FRAMEFORMAT SET");
#elif UNITY_ANDROID || UNITY_IOS
        var isFrameFormatSet = CameraDevice.Instance.SetFrameFormat(PIXEL_FORMAT.GRAYSCALE, true);
        Debug.Log("ANDROID FRAMEFORMAT SET");
#endif
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

    private void Decode()
    {
        if (cameraInitialized)
        {
            try
            {
#if UNITY_EDITOR
                var cameraFeed = CameraDevice.Instance.GetCameraImage(PIXEL_FORMAT.GRAYSCALE);
#elif UNITY_ANDROID || UNITY_IOS
                var cameraFeed = CameraDevice.Instance.GetCameraImage(PIXEL_FORMAT.GRAYSCALE);
#endif

                if (cameraFeed == null)
                {
                    return;
                }


#if UNITY_EDITOR
                RGBLuminanceSource imgSource = new RGBLuminanceSource(cameraFeed.Pixels, cameraFeed.BufferWidth, cameraFeed.BufferHeight, RGBLuminanceSource.BitmapFormat.Gray8);
                var data = barCodeReader.Decode(imgSource);

#elif UNITY_ANDROID || UNITY_IOS
                RGBLuminanceSource imgSource = new RGBLuminanceSource(cameraFeed.Pixels, cameraFeed.BufferWidth, cameraFeed.BufferHeight, RGBLuminanceSource.BitmapFormat.Gray8);
                var data = barCodeReader.Decode(imgSource);
#endif

                if (data != null)
                {
                    // Barcode detected.
                    Debug.Log("Detected");
                    Debug.Log(data.Text);
                    textUI.text = "Detected:" + data.Text;
                    Handheld.Vibrate();
                    data = null;
                }
                else
                {
                    //Check barcode in other orientation
                    Result dataRotated;
                    if ((dataRotated = barCodeReader.Decode(imgSource.rotateCounterClockwise())) != null)
                    {
                        // Barcode detected.
                        Debug.Log("Detected");
                        Debug.Log(dataRotated.Text);
                        textUI.text = "Detected:" + dataRotated.Text;
                        Handheld.Vibrate();
                        dataRotated = null;
                    }
                    //No barcode found in both orientations
                    Debug.Log("No QR code detected !");
                }
            }
            catch (Exception e)
            {
                Debug.LogError(e.Message);
            }

        }
    }

    private void Update()
    {

    }

}













//======================== [ Other Scanner variants ] ========================





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
        yield return new WaitForSeconds(2.25f);

#if UNITY_EDITOR && !(UNITY_ANDROID || UNITY_IOS)
        var isFrameFormatSet = CameraDevice.Instance.SetFrameFormat(PIXEL_FORMAT.GRAYSCALE, true);
#elif UNITY_ANDROID || UNITY_IOS
        var isFrameFormatSet = CameraDevice.Instance.SetFrameFormat(PIXEL_FORMAT.RGB888, true);
#endif

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
#if UNITY_EDITOR && !(UNITY_ANDROID || UNITY_IOS)
                var cameraFeed = CameraDevice.Instance.GetCameraImage(PIXEL_FORMAT.GRAYSCALE);
#elif UNITY_ANDROID || UNITY_IOS
                var cameraFeed = CameraDevice.Instance.GetCameraImage(PIXEL_FORMAT.RGB888);
#endif

                if (cameraFeed == null)
                {
                    return;
                }

#if UNITY_EDITOR && !(UNITY_ANDROID || UNITY_IOS)
                var data = barCodeReader.Decode(cameraFeed.Pixels, cameraFeed.BufferWidth, cameraFeed.BufferHeight, RGBLuminanceSource.BitmapFormat.Gray8);
#elif UNITY_ANDROID || UNITY_IOS
                var data = barCodeReader.Decode(cameraFeed.Pixels, cameraFeed.BufferWidth, cameraFeed.BufferHeight, RGBLuminanceSource.BitmapFormat.RGB24);
#endif
                
                if (data != null)
                {
                    // QRCode detected.
                    Debug.Log("Detected");
                    Debug.Log(data.Text);
                    textUI.text = "Detected:" +data.Text;
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


/*using UnityEngine;
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
*/


/*using TMPro;
using UnityEngine;
using Vuforia;
using ZXing;

public class QRScanner : MonoBehaviour
{

    private bool _isFrameFormatSet = false;

    BarcodeReader _barcodeReader = new BarcodeReader();

    //Output of barcode data
    public TextMeshProUGUI textUI;

    void Start()
    {
        //enable scanner for both orientations (landscape and portrait mode)
        //_barcodeReader.AutoRotate = !_barcodeReader.AutoRotate;
        InvokeRepeating("Autofocus", 0.1f, 0.125f);
        
    }

    void Autofocus()
    {
        CameraDevice.Instance.SetFocusMode(CameraDevice.FocusMode.FOCUS_MODE_TRIGGERAUTO);

        RegognizeQR();
    }

    private Vuforia.Image GetCurrFrame()
    {
        return CameraDevice.Instance.GetCameraImage(PIXEL_FORMAT.RGB888);
    }

    void RegognizeQR()
    {
        if (_isFrameFormatSet == false)
        {
            _isFrameFormatSet = CameraDevice.Instance.SetFrameFormat(PIXEL_FORMAT.RGB888, true);
            _isFrameFormatSet = true;
        }

        var currFrame = GetCurrFrame();

        if (currFrame == null)
        {
            Debug.Log("Camera image capture failure;");
            textUI.text = "fail";
        }
        else
        {
            var imgSource = new RGBLuminanceSource(currFrame.Pixels, currFrame.BufferWidth, currFrame.BufferHeight, RGBLuminanceSource.BitmapFormat.RGB24);
            //imgSource.rotateCounterClockwise();
            //imgSource.rotateCounterClockwise();
            //imgSource.rotateCounterClockwise();

            var result = _barcodeReader.Decode(imgSource);
            if (result != null)
            {
                Debug.Log("RECOGNIZED: " + result.Text);
                textUI.text = result.Text;
            }
        }
    }
}
*/


