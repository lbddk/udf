using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RedTipTestMLeft : MonoBehaviour {

	// Use this for initialization
	void Start () {
		RedTipTestModel.onAllChange.AddListener (onDataChange);
		onDataChange ();
	}

	void onDataChange ()
	{
		int i = 0;
		foreach (Toggle item in GetComponentsInChildren<Toggle>()) {
			item.GetComponentInChildren<Text> ().text = RedTipTestModel.leftItems [i].itemName;

			item.isOn = RedTipTestModel.leftItems [i++].redTipVo.NeedShow > 0;
		}	
		 
	}
	
	 
}
