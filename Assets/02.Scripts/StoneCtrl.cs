using UnityEngine;
using System.Collections;

public class StoneCtrl : MonoBehaviour {
    private Transform tr;
    private Transform targetTr;
    public float speed = 20.0f;
	// Use this for initialization
	void Start () {
        tr = GetComponent<Transform>();
        GameObject[] gameObjects = GameObject.FindGameObjectsWithTag("TARGET");
        targetTr = gameObjects[Random.Range(0, gameObjects.Length)].transform;
	}
	
	// Update is called once per frame
	void Update () {
        //Quaternion rot = Quaternion.LookRotation(targetTr.position, tr.position);
        tr.LookAt(targetTr);
        tr.Translate(Vector3.forward * Time.deltaTime * speed);
	}

    void OnTriggerEnter(Collider coll) {
        if (coll.CompareTag("TARGET"))
        {
            Destroy(this.gameObject);
            Debug.Log("stone");
        }
    }
}
