using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Managers : MonoBehaviour
{
    #region Singleton
    private static Managers instance;

    public static Managers Instance
    {
        get
        {
            // 인스턴스가 없을 경우 초기화
            if (instance == null)
                Init();
            return instance;
        }
    }

    [RuntimeInitializeOnLoadMethod]
    private static void Init()
    {
        // 이미 인스턴스가 있는 경우 초기화
        if (instance != null)
            return;

        // "@Managers"라는 이름의 게임 오브젝트를 찾거나 생성
        GameObject go = GameObject.Find("@Managers");
        if (go == null)
            go = new GameObject("@Managers");

        // Managers 컴포넌트를 게임 오브젝트에 추가
        instance = go.GetOrAddComponent<Managers>();

        // 씬 전환 시 파괴되지 않도록 설정
        DontDestroyOnLoad(go);

        // 매니저들 생성
        instance.CreateManagers();
    }
    #endregion

    // 각각의 매니저들을 private 변수로 선언
    private ResourceManager resource;
    private PoolManager pool;
    private EventManager event_;
    private CoroutineManager routine;
    private DataManager data;
    private ObjectManager _object;
    private FactoryManager factory;


    private GameManager game;

    // 각각의 매니저들에 대한 public 프로퍼티를 추가
    public static ResourceManager Resource { get { return Instance?.resource; } }
    public static PoolManager Pool { get { return Instance?.pool; } }
    public static EventManager Event { get { return Instance?.event_; } }
    public static GameManager Game { get { return Instance?.game; } }
    public static CoroutineManager Routine { get { return Instance.routine; } }
    public static DataManager Data { get { return Instance.data; } }
    public static ObjectManager Object { get { return Instance._object; } }
    public static FactoryManager Factory { get { return Instance.factory; } }


    private void CreateManagers()
    {
        resource = new ResourceManager();
        pool = new PoolManager();
        event_ = new EventManager();
        routine = new CoroutineManager();
        data = new DataManager();
        _object = new ObjectManager();
        factory = new FactoryManager();


        game = GameManager.Instance;
    }
}
