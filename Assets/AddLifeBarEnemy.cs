﻿using UnityEngine;
using System.Collections;

public class AddLifeBarEnemy : MonoBehaviour {

	[SerializeField] GameObject enemyBarPrefab;
	[SerializeField] GameObject testEnemy;

	public void addLifeBarToEnemy(GameObject enemy) {
		GameObject lifeBar = (GameObject)Instantiate (enemyBarPrefab);
		lifeBar.GetComponent<LifeBarEnemyFollow> ().setFollowedEnemy(enemy);
		lifeBar.GetComponent<RectTransform> ().SetParent (gameObject.transform, false);
	}

	// Use this for initialization
	void Start () {
		addLifeBarToEnemy (testEnemy);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
