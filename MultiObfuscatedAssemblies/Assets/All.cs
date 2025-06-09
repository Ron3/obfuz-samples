using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class All : MonoBehaviour
{
    public int x;

    public void Run(BPInfo_NonObfus1 a, BPInfo_NonObfus2 b, BPInfo_Obfus1 c, BPInfo_Obfus2 d)
    {
        x += a.x + 1;
        x += b.x + 2;
        x += c.x + 3;
        x += d.x + 4;
    }
}
