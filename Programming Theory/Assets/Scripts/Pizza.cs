using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pizza : MonoBehaviour, IItem
{
    public int scoreAmount => 5;

    public float scoreMultiplier => 1.2f;
}
