using System;
using UnityEngine;

namespace Game.Scripts.UI
{
    public abstract class Screen : MonoBehaviour
    {

	    protected UIService UIService;

	    public Action OnShow;
	    public Action OnHide;
	    public void SetContainer(UIService uiService)
	    {
		    UIService = uiService;
	    }
		public abstract void Init();

		public abstract void Enable();

	    public abstract void Disable();

	    public virtual void Show(bool state = true)
	    {
		    gameObject.SetActive(state);

		    if (state)
		    {
			    Enable();
			    OnShow?.Invoke();
		    }
		    else
		    {
			    Disable();
			    OnHide?.Invoke();
		    }
	    }
	}
}