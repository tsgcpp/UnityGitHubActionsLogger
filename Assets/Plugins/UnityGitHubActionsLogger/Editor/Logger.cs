using System;
using UnityEditor;
using UnityEngine;

/*
namespace UnityGitHubActionsLogger
{
    public class Logger : ScriptableObject
    {
        static Logger instance;

        [InitializeOnLoadMethod]
        static void Init()
        {
            if (instance != null) return;
            instance = ScriptableObject.CreateInstance<Logger>();
        }

        void OnEnable()
        {
            Application.logMessageReceived += OnMessageRecieved;
        }

        void OnDisable()
        {
            Application.logMessageReceived -= OnMessageRecieved;
        }

        void OnMessageRecieved(string msg, string stack, LogType type)
        {
            Console.WriteLine("::error::" + msg);
        }
    }
}
 */
