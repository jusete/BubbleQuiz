using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestVideo2 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        var vp = gameObject.AddComponent<UnityEngine.Video.VideoPlayer>();
        vp.url = "https://teleonuba.es/teleonuba/2020/12/09/15-vtr-cribados-masivos-palos-ok.mp4";

        vp.isLooping = true;
        vp.renderMode = UnityEngine.Video.VideoRenderMode.MaterialOverride;
        vp.targetMaterialRenderer = GetComponent<Renderer>();
        vp.targetMaterialProperty = "_MainTex";

        vp.Play();
    }
   
}
