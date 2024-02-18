using UnityEngine;

public class MySignalClass
{
    public void MySignalMethod() => Debug.Log("My signal fire");
    public int MyTestAttribute { get; set; } = 15;
}