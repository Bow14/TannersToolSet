using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(SpriteRenderer))]
public class SpriteBehaviourObj : MonoBehaviour
{
    //    //AnthonyRomrell Module  Matching game 1 code

    private SpriteRenderer rendererObj;
    void Awake()
    {
        rendererObj = GetComponent<SpriteRenderer>();
    }

    public void ChangeRendererColor(ColorID obj)
    {
        rendererObj.color = obj.value;
    }

    public void ChangeRenderColor(ColorIDDataList obj)
    {
        rendererObj.color = obj.currentColor.value;
    }

    
}
