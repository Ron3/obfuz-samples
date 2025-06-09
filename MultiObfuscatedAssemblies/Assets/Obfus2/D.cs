using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BPInfo_Obfus2
{
    public int x;

    public void Run(BPInfo_NonObfus1 a, BPInfo_Obfus1 c)
    {
        x = a.x + 1;
        x = c.x + 2;
    }
}
