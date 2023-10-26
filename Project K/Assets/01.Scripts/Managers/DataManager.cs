using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataManager 
{
    public Dictionary<int, NPCData> npcDatas;
    public T Get<T>(int _UID) where T : Data
    {
        if (typeof(NPCData) == typeof(T))
            if (npcDatas.TryGetValue(_UID, out NPCData data))
                return data as T;

        Debug.LogError("�����Ͱ� ��ȯ���� �ʾҽ��ϴ�.");
        return null;
    }

    public DataManager()
    {
        npcDatas = new Dictionary<int, NPCData>();
    }
}

public class Data
{

}

public class NPCData : Data
{

}
