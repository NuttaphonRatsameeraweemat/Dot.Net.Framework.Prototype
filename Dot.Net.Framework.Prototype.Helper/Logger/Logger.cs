﻿using System;

namespace Dot.Net.Framework.Prototype.Helper.Logger
{
    /// <summary>
    /// Logger class is intended for log all activities by using NLog library.
    /// </summary>
    public class Logger : ILogger
    {
        #region [Fields]

        /// <summary>
        /// The session key for Mapped Diagnostic Logical Context (MDLC) of NLog.
        /// </summary>
        private const string NLOG_MDC_SESSION_ID_KEY = "session-id";
        /// <summary>
        /// The NLog logger object.
        /// </summary>
        private readonly NLog.ILogger _nlogger;

        #endregion


        #region [Constructors]

        /// <summary>
        /// Initializes a new instance of the <see cref="Logger" /> class.
        /// </summary>
        /// <param name="nlogger">The NLog logger object.</param>
        public Logger(NLog.ILogger nlogger)
        {
            _nlogger = nlogger;
        }

        #endregion


        #region [Methods]

        /// <summary>
        /// Creates a new session for logging.
        /// </summary>
        public void CreateNewSession()
        {
            NLog.MappedDiagnosticsContext.Set(NLOG_MDC_SESSION_ID_KEY, Guid.NewGuid().ToString());
        }

        /// <summary>
        /// Logs the debug, the message will be logged when debug mode is on.
        /// </summary>
        /// <param name="message">The message.</param>
        public void Debug(string message)
        {
            _nlogger.Debug(message);
        }

        /// <summary>
        /// Logs the error.
        /// </summary>
        /// <param name="ex">The exception.</param>
        /// <param name="message">The additional message.</param>
        public void Error(Exception ex, string message = null)
        {
            _nlogger.Error(ex, message ?? String.Empty);
        }

        /// <summary>
        /// Logs the information such as start and end.
        /// </summary>
        /// <param name="message">The message.</param>
        public void Info(string message)
        {
            _nlogger.Info(message);
        }

        #endregion
    }
}
