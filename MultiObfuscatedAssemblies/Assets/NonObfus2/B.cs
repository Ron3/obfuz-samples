using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BPInfo_NonObfus2
{
    public int x;

    // Start is called before the first frame update
    public void Run(BPInfo_NonObfus1 a, BPInfo_Obfus1 c, BPInfo_Obfus2 d)
    {
        x += a.x + 1;
        x += c.x + 2;
        x += d.x + 3;
    }
}
