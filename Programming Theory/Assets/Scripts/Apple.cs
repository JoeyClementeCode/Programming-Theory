using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Apple : MonoBehaviour, IItem
{
    public int scoreAmount => 3;

    public float scoreMultiplier => 1;

}
