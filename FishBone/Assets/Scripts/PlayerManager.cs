using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerManager : MonoBehaviour {

    public GameObject hitImage;  //当たったときに表示される赤い画面

    public Text hitCountText;  //当たった回数を表示するテキストオブジェクト

    private int hitCount = 0;  //当たった回数 

    private bool hitState = false;  //当たっているかどうか

	// Use this for initialization
	void Start () {
        //最初は赤い画面は非表示にしておく
        hitImage.SetActive(false);
	}
	
	// Update is called once per frame
	void Update () {
        //当たった回数を表示する
        hitCountText.text = "当たった回数：" + hitCount;
    }

    private void OnCollisionEnter(Collision collision) {
        //「プレーヤーがボーンにヒットしたら」かつ「今当たっていない状態」のとき
        if (collision.gameObject.tag == "Bone" && hitState == false) {
            //赤い画面をSetActive(true)にする
            hitImage.SetActive(true);

            //当たった回数を反映させる
            hitCount += 1;

            //stateを「当たっている状態」に変更する
            hitState = true;

            //コルーチンを発動させる
            StartCoroutine(LateCall());
        }
    }

    //赤い画面を2秒後に消すコルーチン
    IEnumerator LateCall() {
        //1秒待つ
        yield return new WaitForSeconds(1);

        //赤い画面をSetActive(false)にする
        hitImage.SetActive(false);

        //stateを「当たっていない状態」に戻す
        hitState = false;
    }
}
