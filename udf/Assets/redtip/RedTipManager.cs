using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedTipManager 
{
    public static Dictionary<RedTipEnum, BaseRedTipVo> allTipVo=new Dictionary<RedTipEnum, BaseRedTipVo>();

	public	static	void init () {
		allTipVo[RedTipEnum.TIP_MAIN_BUTTON]=new BaseRedTipVo(null,true);
	    allTipVo[RedTipEnum.TIP_M1_LEFT]=new BaseRedTipVo(allTipVo[RedTipEnum.TIP_MAIN_BUTTON],true);
		allTipVo[RedTipEnum.TIP_M1_RIGHT]=new BaseRedTipVo(allTipVo[RedTipEnum.TIP_MAIN_BUTTON]);


		for (int i = 0; i < 10; i++) {
			allTipVo[RedTipEnum.TIP_M2_LIST+i]=new BaseRedTipVo(allTipVo[RedTipEnum.TIP_M1_LEFT]);

		}
		allTipVo[RedTipEnum.TIP_M3]=new BaseRedTipVo(allTipVo[RedTipEnum.TIP_M1_RIGHT]);

		Debug.LogError ((int)RedTipEnum.TIP_M1_LEFT);
		Debug.LogError ((int)RedTipEnum.TIP_M2_LIST);
		Debug.LogError ((int)RedTipEnum.TIP_M3);
	}
	

}
