using UnityEngine;
/// <summary>
/// Singleton Pattern Test Sample
/// </summary>
public class Test05 : MonoBehaviour
{
    private void Awake()
    {
        Test();
    }

    // Start is called before the first frame update
    void Start()
    {
        Test();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return))
        {
            Test();
        }
    }

    void Test()
    {
        MyAudioController.Instance.Print();
        MyGameManager.Instance.Print();
    }
}

