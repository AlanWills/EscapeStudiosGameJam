using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

public class HideGameObject : CustomStep
{
    public GameObject GameObjectToHide;
    
    public override void DoStep()
    {
        GameObjectToHide.SetActive(false);
    }
}