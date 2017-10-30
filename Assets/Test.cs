using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boss{
	private int hp=100; //体力
	private int power=25; //攻撃力
	private int mp=53; //魔力

	//攻撃用の関数
	public void magic(int mag){
			if (mp >= 5) {
			//MPを減らす
			mp -= mag;
				Debug.Log ("魔法攻撃をした。残りMPは" + this.mp + "。");
			} else {
				Debug.Log ("MPが足りないため魔法が使えない。");
			}
		}


	//防御用の関数
	public void defence(int damage){
		Debug.Log (damage + "のダメージを受けた");
		//HPを減らす
		this.hp -= damage;
	}
}

public class Test : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
		//配列の初期化
		int[] array={10,20,30,40,50};
		//配列の各要素を順番に表示
		for (int i = 0; i < array.Length; i++) {
			Debug.Log (array [i]);
		}
		//配列の各要素を逆順に表示
		for (int i = 4; i >= 0; i--) {
			Debug.Log (array [i]);
		}

			//bossクラスの変数を宣言してインスタンスを代入
			boss lastboss = new boss ();
		//magic関数を11回ループ
		for (int i = 0; i <= 10; i++) {
			//攻撃用の関数を呼び出す
			lastboss.magic (5);
		}
			//防御用の関数を呼び出す
			lastboss.defence (3);
		}


	// Update is called once per frame
	void Update () {
		
	}
}
