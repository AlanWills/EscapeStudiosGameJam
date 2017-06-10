using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

public abstract class CustomStep : MonoBehaviour
{
    public abstract void OnSuccess();
    public abstract void OnFailure();
}