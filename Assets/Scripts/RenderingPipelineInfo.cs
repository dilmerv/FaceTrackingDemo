using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Rendering;

public class RenderingPipelineInfo : MonoBehaviour
{
    [SerializeField]
    private TextMeshProUGUI pipelineInfo;
    
    void Start()
    {
        pipelineInfo.text = $"Current Rendering Pipeline: {GraphicsSettings.currentRenderPipeline.name}";    
    }
}
