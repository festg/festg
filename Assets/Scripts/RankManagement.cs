using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RankManagement : MonoBehaviour {

	// Use this for initialization
	void Start () {
		DontDestroyOnLoad(this);

	}
	RankKind rank;
public void SetScore(float score) {
	if (score >= (int)RankKind.S) {
		rank = RankKind.S;
	} else if (score >= (int)RankKind.A) {
		rank = RankKind.A;
	} else if (score >= (int)RankKind.B) {
		rank = RankKind.B;
	} else if (score >= (int)RankKind.C) {
		rank = RankKind.C;
	} else if (score >= (int)RankKind.D) {
		rank = RankKind.D;
	}
}


}
