/*using UnityEngine;
using UnityEngine.Networking;
using System.Collections;
using Vuforia;

public class DownLoadIT : MonoBehaviour
{
    void Start()
    {
        StartCoroutine(CreateImageTargetFromDownloadedTexture());
    }

    IEnumerator CreateImageTargetFromDownloadedTexture()
    {
        using (UnityWebRequest uwr = UnityWebRequestTexture.GetTexture("https://myPage.com/myImage.jpg"))
        {
            yield return uwr.SendWebRequest();

            if (uwr.isNetworkError || uwr.isHttpError)
            {
                Debug.Log(uwr.error);
            }
            else
            {
                ObjectTracker objectTracker = TrackerManager.Instance.GetTracker<ObjectTracker>();

                // Get downloaded texture once the web request completes
                Texture2D texture = DownloadHandlerTexture.GetContent(uwr);

                // get the runtime image source and set the texture
                var runtimeImageSource = objectTracker.RuntimeImageSource;
                runtimeImageSource.SetImage(texture, 0.15f, "myTargetName");

                // create a new dataset and use the source to create a new trackable
                var dataset = objectTracker.CreateDataSet();
                var trackableBehaviour = dataset.CreateTrackable(runtimeImageSource, "myTargetName");

                // add the DefaultTrackableEventHandler to the newly created game object
                trackableBehaviour.gameObject.AddComponent<DefaultTrackableEventHandler>();

                // activate the dataset
                objectTracker.ActivateDataSet(dataset);

                // TODO: add virtual content as child object(s)
            }
        }
    }
}*/