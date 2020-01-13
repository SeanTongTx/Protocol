using EditorPlus;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CustomSeanLibEditor("Protocol", IsDoc = true)]
public class ProtocolDoc : EditorMarkDownWindow
{
    public override bool SearchField => true;
    public override bool EditScript => false;
}
