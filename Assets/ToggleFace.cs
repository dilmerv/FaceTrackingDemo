using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;

public class ToggleFace : MonoBehaviour
{
    public ARFaceManager arFaceManager;

    public GameObject[] faces;

    private float timer;

    [SerializeField]
    private float frequency = 1.0f;

    [SerializeField]
    private float maxUntilSpawn = 1.0f;

    private int index = -1;

    void Update()
    {
        if (timer <= maxUntilSpawn)
        {
            timer += Time.deltaTime * frequency;
        }
        else
        {
            if(index + 1 == faces.Length)
            {
                index = -1;
            }
            index++;


            if(arFaceManager != null)
                DestroyImmediate(arFaceManager);
            
            arFaceManager = gameObject.AddComponent<ARFaceManager>();
            arFaceManager.facePrefab = faces[index];

            timer = 0;
            Debug.Log(index);
        }
    }
}