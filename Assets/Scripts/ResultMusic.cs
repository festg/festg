using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResultMusic : MonoBehaviour {
    [SerializeField]
    AudioSource audioSource;


    [SerializeField]
    AudioClip RankS;

    [SerializeField]
    AudioClip RankA;

    [SerializeField]
    AudioClip RankBC;

    [SerializeField]
    AudioClip RankD;

    // Use this for initialization
    void Start (){
        switch(GameObject.Find("Rank manegement").GetComponent<RankManagement>().GetRank())
        {
            case RankKind.S:
                audioSource.clip = RankS;
                break;
            case RankKind.A:
                audioSource.clip = RankA;
                break;
            case RankKind.B:
            case RankKind.C:
                audioSource.clip = RankBC;
                break;
            case RankKind.D:
                audioSource.clip = RankD;
                break;
            default:
                return;
        }
        audioSource.Play();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
