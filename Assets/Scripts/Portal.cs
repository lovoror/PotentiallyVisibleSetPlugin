﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Portal
{
    public int id;
    public int x;
    public int z;
    [System.NonSerialized]
    public List<Vector3> rayStartPointList;
}
