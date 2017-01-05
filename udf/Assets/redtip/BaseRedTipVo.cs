using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class BaseRedTipVo
{
 
	private bool showCountMode;
	private int needShow=0;
	public int NeedShow

	    {
	        get { return needShow; }
	        set
	        {
	            if (needShow == value) return;
	            needShow=value;
	            updateRidTip();
	        }
	    }
    HashSet<BaseRedTipVo> children;
    private BaseRedTipVo parent;
    public GameObject view;
	public Text txtCount;
   

	public BaseRedTipVo(BaseRedTipVo parent,bool showCountMode=false)
    {
		this.showCountMode = showCountMode;
		if(parent!=null)
        setParent(parent);
    }

    public void setParent(BaseRedTipVo parent)
    {
        if (parent.children == null)
        {
            parent.children = new HashSet<BaseRedTipVo>();
        }
        if (this.parent != null) this.parent.children.Remove(this);
        this.parent = parent;
        parent.children.Add(this);


    }


    private void updateRidTip()
    {
        int oldCount = needShow;
        if(children!=null){
			needShow = 0;
            foreach (var c in children)
            {
				needShow += c.needShow>0?1:0;

            }
        }

        if(view!=null)view.SetActive(needShow>0);
		if (txtCount != null) {
			if (showCountMode) {
				txtCount.text = needShow.ToString ();
				txtCount.enabled = true;
			} else {
				txtCount.enabled = false;
			}
		}
		if (oldCount != needShow||children==null)
        {
            if (parent != null)
            {
                parent.updateRidTip();
            }
        }

    }

}
