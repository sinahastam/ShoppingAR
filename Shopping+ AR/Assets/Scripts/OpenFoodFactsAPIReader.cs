using System;
using System.Collections;
using UnityEngine;
using SimpleJSON;
using UnityEngine.Networking;
using TMPro;
using OpenFoodFactsAPIData;
using UnityEngine.UI;



/// <summary>
/// Class for handling API data from OpenFoodFacts
/// </summary>
public class OpenFoodFactsAPIReader : MonoBehaviour
{
    /// <summary>
    /// Variable for barcode number of current product
    /// </summary>
    public TextMeshProUGUI barcode;

    /// <summary>
    /// Variable for printing JSON product data on screen
    /// </summary>
    public TextMeshProUGUI productAPIData;

    private string productJson;

    /// <summary>
    /// The current product
    /// </summary>
    public ProductDataClass productObject;

    private bool jsonIsDone = false;

    /// <summary>
    /// Image from product
    /// </summary>
    public Image productImage;

    /// <summary>
    /// Product Name
    /// </summary>
    public TextMeshProUGUI productName;

    /// <summary>
    /// Requests product data from OpenFoodFacts using current barcode number 
    /// </summary>
    /// @see barcode
    public void GetJsonData()
    {
        //barcode.text = "20005733";  //hardcoded product barcode for testing
        StartCoroutine(RequestWebService());
    }

    IEnumerator RequestWebService()
    {
        string getDataUrl = "https://world-de.openfoodfacts.org/api/v0/product/" + barcode.text + ".json";
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
                        productJson = jsonData.ToString();
                    }
                }
            }
        }

        jsonIsDone = true;
    }

    /// <summary>
    /// Downloads image of product from web and displays it on UI
    /// </summary>
    IEnumerator CreateImageFromDownloadedTexture()
    {
        using (UnityWebRequest uwr = UnityWebRequestTexture.GetTexture(ProductManager.GetCurrentProduct().Product.ImageUrl))
        {
            yield return uwr.SendWebRequest();

            if (uwr.isNetworkError || uwr.isHttpError)
            {
                Debug.Log(uwr.error);
            }
            else
            {

                // Get downloaded texture once the web request completes
                Texture2D texture = DownloadHandlerTexture.GetContent(uwr);

                //Displaying image on UI
                productImage.preserveAspect = true;
                productImage.sprite = Sprite.Create(texture, new Rect(0, 0, texture.width, texture.height), new Vector2(0, 0));

            }
        }
    }

    //Update is called once per frame
    void Update()
    {
        if (jsonIsDone)
        {
            //convert json string to class
            try
            {
                productObject = ProductDataClass.FromJson(productJson.ToString());
            }
            catch (NullReferenceException ex)
            {
                Debug.Log("Error Converting " + ex.ToString());
            }


            if (productObject != null)
            {
                try
                {
                    ProductManager.SetCurrentProduct(productObject);
                    Debug.Log("Product Object created: " + ProductManager.GetCurrentProduct().Product.ProductName + " " + ProductManager.GetCurrentProduct().Product.Brands);

                    StartCoroutine(CreateImageFromDownloadedTexture());

                    //Update Swipe Up UI Text
                    //Buggy on android UI not updating
                    productName.SetText(ProductManager.GetCurrentProduct().Product.ProductName);
                    GameObject.Find("ProductCompanyText").GetComponent<TextMeshProUGUI>().SetText(ProductManager.GetCurrentProduct().Product.Brands);

                }
                catch (NullReferenceException ex)
                {
                    Debug.Log("NullRefrenceExeption " + ex.ToString());
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