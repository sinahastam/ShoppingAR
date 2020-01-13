using OpenFoodFactsAPIData;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProductManager : MonoBehaviour
{
    // Start is called before the first frame update

    private static ProductDataClass product;

    public static ProductDataClass GetCurrentProduct()
    {
        return product;
    }

    public static void SetCurrentProduct(ProductDataClass newProduct)
    {
        product = newProduct;
    }

}
