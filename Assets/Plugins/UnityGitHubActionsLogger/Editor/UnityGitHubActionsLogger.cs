using UnityEngine;
using System;

namespace UnityGitHubActionsLogger
{
    public class UnityGitHubActionsLogger : ILogHandler
    {
        private ILogHandler _defaultLogHandler = Debug.unityLogger.logHandler;

        public UnityGitHubActionsLogger()
        {
            Debug.unityLogger.logHandler = this;
        }

        public void LogFormat(LogType logType, UnityEngine.Object context, string format, params object[] args)
        {
            if (logType == LogType.Error)
            {
                _defaultLogHandler.LogFormat(logType, context, "::error::" + format, args);
            }
            else
            {
                _defaultLogHandler.LogFormat(logType, context, format, args);
            }
        }

        public void LogException(Exception exception, UnityEngine.Object context)
        {
            _defaultLogHandler.LogFormat(LogType.Error, context, "::error::" + exception);
        }
    }
}
