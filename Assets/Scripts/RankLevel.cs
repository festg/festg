using UnityEngine;
using UnityEngine.UI;

public class RankLevel : MonoBehaviour {
    [SerializeField]
    Text text;

    // Use this for initialization
    void Start()
    {
        var rankManagement = GameObject.Find("Rank manegement").GetComponent<RankManagement>();
        text.text = rankManagement.GetRank().ToString();
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
