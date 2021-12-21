
/// <summary>
/// Singleton Sample
/// </summary>
public class MyGameManager : Singleton<MyGameManager>, PrintDebug
{
    public void Print()
    {
        DebugX.Log(this);
    }
}
