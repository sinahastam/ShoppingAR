using OpenFoodFactsAPIData;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Class for managing the current product
/// </summary>
public class ProductManager : MonoBehaviour
{
    private static ProductDataClass product;


    /// <summary>
    /// Get the current product
    /// </summary>
    /// <returns>The current product</returns>
    public static ProductDataClass GetCurrentProduct()
    {
        return product;
    }

    /// <summary>
    /// Set the new current product
    /// </summary>
    /// <param name="newProduct">The new product</param>
    public static void SetCurrentProduct(ProductDataClass newProduct)
    {
        product = newProduct;
    }

}
