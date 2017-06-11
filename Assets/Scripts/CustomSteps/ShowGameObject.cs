using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

public class ShowGameObject : CustomStep
{
    public GameObject GameObjectToShow;
    
    public override void DoStep()
    {
        GameObjectToShow.SetActive(true);
    }
}