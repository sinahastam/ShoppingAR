using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

/// <summary>
/// Class for Swipe-Up panel
/// </summary>
public class PageSwiper : MonoBehaviour, IDragHandler, IEndDragHandler
{
    private Vector3 panelLocation;

    /// <summary>
    /// Threshold
    /// </summary>
    public float percentThreshold = 0.2f;

    /// <summary>
    /// Easing duration in seconds
    /// </summary>
    public float easing = 0.5f;

    /// <summary>
    /// Maximum number of pages of the panel
    /// </summary>
    public int totalPages = 2;

    /// <summary>
    /// The current page number of the panel
    /// </summary>
    public int currentPage = 1;

    // Start is called before the first frame update
    void Start()
    {
        panelLocation = transform.position;
    }

    public void OnDrag(PointerEventData data)
    {
        float difference = data.pressPosition.y - data.position.y;
        transform.position = panelLocation - new Vector3(0, difference, 0);
    }

    public void OnEndDrag(PointerEventData data)
    {
        float percentage = (data.pressPosition.y - data.position.y) / Screen.height;
        if (Mathf.Abs(percentage) >= percentThreshold)
        {
            Vector3 newLocation = panelLocation;
            if (-percentage > 0 && currentPage < totalPages)
            {
                currentPage++;
                newLocation += new Vector3(0, 1950, 0);
            }
            else if (-percentage < 0 && currentPage > 1)
            {
                currentPage--;
                newLocation += new Vector3(0, -1950, 0);
            }
            StartCoroutine(SmoothMove(transform.position, newLocation, easing));
            panelLocation = newLocation;
        }
        else
        {
            StartCoroutine(SmoothMove(transform.position, panelLocation, easing));
        }
    }

    IEnumerator SmoothMove(Vector3 startpos, Vector3 endpos, float seconds)
    {
        float t = 0f;
        while (t <= 1.0)
        {
            t += Time.deltaTime / seconds;
            transform.position = Vector3.Lerp(startpos, endpos, Mathf.SmoothStep(0f, 1f, t));
            yield return null;
        }
    }
}