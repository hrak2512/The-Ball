﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class StageSelectManager : MonoBehaviour {

	public GameObject[] StageButtons;	//ステージ選択ボタン

	// Use this for initialization
	void Start () {
		//どのステージまでクリアしているのかをロード（セーブ前なら「０」）
		int clearStageNo = PlayerPrefs.GetInt ("CLEAR",0);

		//ステージボタンを有効化
		for (int i = 0; i <= StageButtons.GetUpperBound (0); i++) {
			bool b;

			if (clearStageNo < i) {
				b = false;	//前ステージをクリアしていなければ無効
			} else {
				b = true;	//前ステージをクリアしていれば有効
			}

			//ボタンの有効／無効を設定
			StageButtons [i].GetComponent<Button> ().interactable = b;
		}
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	//ステージ選択ボタンを押した
	public void PushStageSelectButton(int stageNo) {
		//ゲームシーンへ
		SceneManager.LoadScene ("PuzzleScene" + stageNo);
	}
}
