using UnityEngine;
using System.Collections;

public class EffectMgr : MonoBehaviour {
    public static EffectMgr instance;
    public GameObject stone;
    public Transform stonePosition;

    void Awake() {
        if (instance == null)
        {
            instance = this;
        }
    }
	// Use this for initialization
	void Start () {
        stonePosition = GameObject.Find("StonePosition").transform;
        stone = Resources.Load<GameObject>("Prefabs/stone");
        StartCoroutine(this.CreateStone());
	}
	
    IEnumerator CreateStone() {
        while(true) {
            GameObject _stone = (GameObject)Instantiate(stone, stonePosition.position, Quaternion.identity);
            yield return new WaitForSeconds(2.0f);
        }
    }
}
