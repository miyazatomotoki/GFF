using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Scale : MonoBehaviour
{
    public float size;
    bool scale = false;
    void Update()
    {
        if (!scale)
        {
            this.transform.localScale = new Vector2(size,size);
            scale = true;
        }
    }
}