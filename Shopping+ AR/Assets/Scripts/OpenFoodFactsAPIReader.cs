using System;
using System.Collections;
using UnityEngine;
using SimpleJSON;
using UnityEngine.Networking;
using TMPro;

public class OpenFoodFactsAPIReader : MonoBehaviour
{
    //Barcode of Product
    public TextMeshProUGUI barcode;

    public TextMeshProUGUI productAPIData;
    private string productJson;

    public ProductDataClass productObject;
    private bool jsonIsDone = false;

    public void GetJsonData()
    {
        barcode.text = "20005733";  //hardcoded product barcode
        StartCoroutine(RequestWebService());
    }

    IEnumerator RequestWebService()
    {
        string getDataUrl = "https://world-de.openfoodfacts.org/api/v0/product/" +barcode.text +".json";
        print(getDataUrl);

        using (UnityWebRequest webData = UnityWebRequest.Get(getDataUrl))
        {

            yield return webData.SendWebRequest();
            if (webData.isNetworkError || webData.isHttpError)
            {
                print("---------------- ERROR ----------------");
                print(webData.error);
            }
            else
            {
                if (webData.isDone)
                {
                    JSONNode jsonData = JSON.Parse(System.Text.Encoding.UTF8.GetString(webData.downloadHandler.data));

                    if (jsonData == null)
                    {
                        print("---------------- NO DATA ----------------");
                    }
                    else
                    {
                        print("---------------- JSON DATA ----------------");
                        print("jsonData.Count:" + jsonData.Count);
                        print(jsonData.ToString());
                        productAPIData.text = jsonData.ToString();
                        productJson = jsonData.ToString();
                    }
                }
            }
        }

        jsonIsDone = true;
    }

    //Update is called once per frame
    void Update()
    {
        if (jsonIsDone)
        {
            //convert json string to class
            productObject = JsonUtility.FromJson<ProductDataClass>(productJson);

            if (productObject != null)
            {
                try
                {
                    Debug.Log("" + productObject.Product.NutritionGrades + " " + productObject.Product.GenericName);
                }
                catch (NullReferenceException ex)
                {
                    Debug.Log("NullRefrenceExeption" +ex.ToString());
                }
            }
            else
            {
                Debug.Log("ERROR NULL OBJECT");
            }
            jsonIsDone = false;
        }
        
    }

}