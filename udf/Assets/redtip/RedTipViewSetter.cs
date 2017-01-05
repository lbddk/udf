using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RedTipViewSetter : MonoBehaviour
{
    public RedTipEnum tipEnum;
	public int index = 0;
	// Use this for initialization
	void Start ()
	{
	    RedTipManager.allTipVo[tipEnum+index].view = gameObject;
		RedTipManager.allTipVo [tipEnum + index].txtCount = transform.Find ("count").GetComponent<Text> ();
	    gameObject.SetActive(false);
	    Destroy(this);
	}

}
