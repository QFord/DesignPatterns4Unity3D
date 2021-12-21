using UnityEngine;
/// <summary>
/// Singleton : Implementation in Unity3d C#
/// <see cref="http://www.unitygeek.com/unity_c_singleton/"/>
/// </summary>
/// <typeparam name="T"></typeparam>
public class GenericSingletonClass<T> : MonoBehaviour where T : Component
{
    private static T instance;
    public static T Instance
    {
        get
        {
            if (instance == null)
            {
                instance = FindObjectOfType<T>();
                if (instance == null)
                {
                    GameObject obj = new GameObject();
                    obj.name = typeof(T).Name;
                    instance = obj.AddComponent<T>();
                }
            }
            return instance;
        }
    }

    public virtual void Awake()
    {
        //Debug.Log("GenericSingletonClass.cs Awake() invoke.");
        if (instance == null)
        {
            instance = this as T;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }
}
