using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BlinkAnimation : MonoBehaviour {
	[SerializeField]
	Text text;
	float angle = 0;
	void Update () {
		angle += Mathf.Deg2Rad;
	var result = Mathf.Sin(angle);
	Color color = text.color;
	

		float temp;
		temp = Mathf.Abs(result);
		color.a = temp;
		text.color = color;
	}
}
