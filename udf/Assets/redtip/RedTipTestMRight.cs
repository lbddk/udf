using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RedTipTestMRight : MonoBehaviour {

	// Use this for initialization
	void Start () {
		RedTipTestModel.onAllChange.AddListener (onDataChange);
		onDataChange ();
	}

	void onDataChange ()
	{
		 
		Toggle item = GetComponentInChildren<Toggle>();
		item.GetComponentInChildren<Text> ().text = RedTipTestModel.rightItem.itemName;

		item.isOn = RedTipTestModel.rightItem.redTipVo.NeedShow > 0;
		}	
		 

	
	 
}
