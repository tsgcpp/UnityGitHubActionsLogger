using UnityEngine;

public sealed class Builder
{
    internal static void CallMessage()
    {
        Debug.Log("This is Debug.Log");
        Debug.LogWarning("This is Debug.LogWarning");
        Debug.LogError("This is Debug.LogError");
        Debug.LogException(new System.Exception("This is Debug.LogException"));
    }
}
