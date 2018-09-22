using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bar : MonoBehaviour {

    [SerializeField]
    private RectTransform rectTransform;

    private float maxWidth;

    private int currentVal;
    private int maxVal;

    private void Start()
    {
        maxWidth = rectTransform.rect.width;
    }

    public void SetMaxVal(int mval)
    {
        maxVal = mval;
    }

    public int GetVal() { return currentVal; }

    public void SetVal(int val){
        currentVal = val;
        var size = rectTransform.sizeDelta;
        size.Set(  (currentVal / (float)maxVal) * maxWidth,size.y);
        rectTransform.sizeDelta= size;
    }

}
