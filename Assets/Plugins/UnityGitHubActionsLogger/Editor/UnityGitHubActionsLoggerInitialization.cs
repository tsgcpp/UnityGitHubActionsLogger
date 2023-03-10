using UnityEngine;
using UnityEditor;

namespace UnityGitHubActionsLogger
{
    [InitializeOnLoad]
    public sealed class UnityGitHubActionsLoggerInitialization
    {
        static UnityGitHubActionsLoggerInitialization()
        {
            Debug.Log("[UnityGitHubActionsLogger] Use UnityGitHubActionsLogger222");
            if (!Application.isBatchMode)
            {
                return;
            }

            Debug.Log("[UnityGitHubActionsLogger] Use UnityGitHubActionsLogger");
            Debug.unityLogger.logHandler = new UnityGitHubActionsLogger();
        }
    }

}
