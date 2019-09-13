using UnityEngine;
using System.Collections;


public class PusherScript : MonoBehaviour {
    Vector3 initPosition;
    Vector3 newPosition;

    // Use this for initializatio
    void Start()
    {
        /*
         このスクリプトを付けたゲームオブジェクト(this)の
         トランスフォームコンポーネント(transform)の
         位置(position)をinitPositionに格納している。
         */
        initPosition = this.transform.position;
    }

    //Update is called once per frame 
    void Update() {
        /*
         プッシャーが反復運動するように、フレーム毎に位置を更新している。
         ここでは、ｚ軸方向に反復運動するようにしている。
         反復運動の移動モデルはsin関数である。
         */
        newPosition = new Vector3(initPosition.x,
                                  initPosition.y,
                                  initPosition.z + Mathf.Sin(Time.time));
        /*
        Start関数内ではthis.transform.positionにてゲームオブジェクトの
        トランスフォームコンポーネントの情報を取得していた。
        トランスフトランスフォームコンポーネント以外のコンポーネントは
          GetComponent()の様に取得する必要がある（Unity5から）。
         */
        this.GetComponent<Rigidbody>().MovePosition(newPosition);

    }
}




