using UnityEngine;
using JetBrains.Annotations;

/// <summary>
/// 单例模式在Unity中的实现比较特殊（The singleton pattern is implemented in Unity in a special way）
/// 下面的链接提供了详细的参考资料，单例模式在Unity中的实现，并非那么简单（The links below provide a good reference,
/// but the singleton pattern is not that simple to implement in Unity）
///<see cref="https://gamedev.stackexchange.com/questions/116009/in-unity-how-do-i-correctly-implement-the-singleton-pattern"/>
/// </summary>

/*
 Create object        Removes scene        Global access?               Keep across
if not in scene?      duplicates?                                       Scene loads?

     Yes                  Yes                  Yes                     Yes (optional)
 */

/*
1. It's thread-safe.
2. It avoids bugs related to acquiring (creating) singleton instances when the application is quitting
   by ensuring that singletons cannot be created after OnApplicationQuit(). (And it does so with a single global flag,
   instead of each singleton type having their own)
3. It uses Unity 2017's Mono Update (roughly equivalent to C# 6). (But it can easily be adapted for the ancient version)
4. It comes with some free candy!
 */

public abstract class Singleton<T> : Singleton where T : MonoBehaviour
{
    #region  Fields
    [CanBeNull]
    private static T _instance;

    [NotNull]
    // ReSharper disable once StaticMemberInGenericType
    private static readonly object Lock = new object();

    [SerializeField]
    private bool _persistent = true;
    #endregion

    #region  Properties
    [NotNull]
    public static T Instance
    {
        get
        {
            if (Quitting)
            {
                Debug.LogWarning($"[{nameof(Singleton)}<{typeof(T)}>] Instance will not be returned because the application is quitting.");
                // ReSharper disable once AssignNullToNotNullAttribute
                return null;
            }
            lock (Lock)
            {
                if (_instance != null)
                    return _instance;
                var instances = FindObjectsOfType<T>();
                var count = instances.Length;
                if (count > 0)
                {
                    if (count == 1)
                        return _instance = instances[0];
                    Debug.LogWarning($"[{nameof(Singleton)}<{typeof(T)}>] There should never be more than one {nameof(Singleton)} of type {typeof(T)} in the scene, but {count} were found. The first instance found will be used, and all others will be destroyed.");
                    for (var i = 1; i < instances.Length; i++)
                        Destroy(instances[i]);
                    return _instance = instances[0];
                }

                //Debug.Log($"[{nameof(Singleton)}<{typeof(T)}>] An instance is needed in the scene and no existing instances were found, so a new instance will be created.");
                return _instance = new GameObject($"({nameof(Singleton)}){typeof(T)}")
                           .AddComponent<T>();
            }
        }
    }
    #endregion

    #region  Methods
    private void Awake()
    {
        if (_persistent)
            DontDestroyOnLoad(gameObject);
        OnAwake();
    }

    protected virtual void OnAwake() { }
    #endregion
}

public abstract class Singleton : MonoBehaviour
{
    #region  Properties
    public static bool Quitting { get; private set; }
    #endregion

    #region  Methods
    private void OnApplicationQuit()
    {
        Quitting = true;
    }
    #endregion
}