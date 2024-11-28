using UnityEngine;

public class FixOrthographicSize : MonoBehaviour
{
    private float originalSize;

    void Start()
    {
        originalSize = Camera.main.orthographicSize;
    }

    void Update()
    {
        if (Camera.main.orthographicSize != originalSize)
        {
            Camera.main.orthographicSize = originalSize;
        }
    }
}
