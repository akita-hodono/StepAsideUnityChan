using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class itemsController : MonoBehaviour
{
    /*CarPrefabのオブジェクト
    private GameObject carPrefab;*/


    // Start is called before the first frame update
    void Start()
    {
        /*のオブジェクトを取得
        this.carPrefab = GameObject.Find("CarPrefab");*/

    }
        // Update is called once per frame
        void Update()
        {

        }

    private void OnTriggerEnter(Collider other)
    {
        /*Debug.Log("hit1");*/
        //障害物に衝突した場合
        if (other.gameObject.tag == "BehindTag")
        {
            //削除する。
            Debug.Log("hit");
            Destroy(this.gameObject);
        }
    }
  
}
    

