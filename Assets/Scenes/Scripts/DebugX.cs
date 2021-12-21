using UnityEngine;

public class DebugX
{
    public static void Log(Object obj)
    { 
        Debug.Log(string.Format("[{0}]: It's a test for {1}.", Time.realtimeSinceStartup, obj.GetType().BaseType.Name));
    }
}

public interface PrintDebug
{
    public void Print();
}