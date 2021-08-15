using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cookie : MonoBehaviour, IItem
{
    public int scoreAmount => 2;

    public float scoreMultiplier => 1.6f;
}
