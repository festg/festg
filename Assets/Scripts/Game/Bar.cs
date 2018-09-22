using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bar : MonoBehaviour {

    [SerializeField]
    private RectTransform rectTransform;

    private float maxWidth;

    private float currentVal;
    private float maxVal;

    private void Start()
    {
        maxWidth = rectTransform.rect.width;
    }

    public void SetMaxVal(float mval)
    {
        maxVal = mval;
    }

    public float GetVal() { return currentVal; }

    public void SetVal(float val){
        currentVal = val;
        var size = rectTransform.sizeDelta;
        size.Set(  (currentVal / (float)maxVal) * maxWidth,size.y);
        rectTransform.sizeDelta= size;
    }

}
