
/// <summary>
/// GenericSingletonClass Sample
/// </summary>
public class MyAudioController : GenericSingletonClass<MyAudioController>, PrintDebug
{
    public void Print()
    {
        DebugX.Log(this);
    }
}
