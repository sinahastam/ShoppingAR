using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;
using ZXing;
using System;
using TMPro;


/// <summary>
/// Class for handling the QRScanner/Barcode reader
/// </summary>
[AddComponentMenu("System/QRScanner")]
public class QRScanner : MonoBehaviour
{

    private bool cameraInitialized;
    private BarcodeReader barCodeReader;

    /// <summary>
    /// Barcode number
    /// </summary>
    public TextMeshProUGUI textUI;

    /// <summary>
    /// Init barcode reader and starts the continuous scanning
    /// </summary>
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
        InvokeRepeating("Decode", 1f, 1f);
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

                    //show barcode number on UI
                    textUI.text = data.Text;

                    //Get API Data
                    GameObject.Find("OpenFoodFactsAPIReader").GetComponent<OpenFoodFactsAPIReader>().GetJsonData();

                    Handheld.Vibrate();
                    data = null;
                }
                else
                {
                    //Try check barcode in other orientation
                    Result dataRotated;
                    if ((dataRotated = barCodeReader.Decode(imgSource.rotateCounterClockwise())) != null)
                    {
                        // Barcode detected.
                        Debug.Log("Detected");
                        Debug.Log(dataRotated.Text);

                        //show barcode number on UI
                        textUI.text = dataRotated.Text;

                        //Get API Data
                        GameObject.Find("OpenFoodFactsAPIReader").GetComponent<OpenFoodFactsAPIReader>().GetJsonData();

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

}