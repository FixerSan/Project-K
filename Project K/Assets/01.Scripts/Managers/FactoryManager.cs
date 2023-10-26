using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static Define;

public class FactoryManager : MonoBehaviour
{
    public void CreateNPC(Define.NPC _npc, int _UID)
    {
        NPC npc = new NPCs.TestNPC.One();

    }
}
