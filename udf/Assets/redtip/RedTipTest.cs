using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RedTipTest : MonoBehaviour {

	// Use this for initialization
	void Awake () {
		RedTipManager.init ();
		RedTipTestModel.rightItem = new RedTipTestItemVo (){itemName="item1",redTipVo=RedTipManager.allTipVo [RedTipEnum.TIP_M3]};
		RedTipTestModel.leftItems = new List<RedTipTestItemVo> ();
		for (int i = 0; i < 4; i++) {
			RedTipTestModel.leftItems.Add (new RedTipTestItemVo (){itemName="item"+(i+1),redTipVo=RedTipManager.allTipVo [RedTipEnum.TIP_M2_LIST+i]});

		}
		GetComponent<Button> ().onClick.AddListener (onClk);
	}
	
	 
	void onClk ()
	{
		RedTipTestModel.rightItem.redTipVo.NeedShow = Random.Range (0, 100) >= 50?1:0;
 		foreach (var item in RedTipTestModel.leftItems) {
			item.redTipVo.NeedShow = Random.Range (0, 100) >= 50?1:0;
 		}
		RedTipTestModel.onAllChange.Invoke ();

	}
}
