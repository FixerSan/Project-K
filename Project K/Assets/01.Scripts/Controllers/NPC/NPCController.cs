using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCController : MonoBehaviour
{
    public NPC npc;

}

public abstract class NPC
{
    public abstract void Interaction();
}
