﻿using System;

namespace CSSMinifier.Logging
{
	public static class ILogEvents_Extensions
	{
		/// <summary>
		/// Wrap logging request in a try..catch and swallow any exception - this is an extension method that guarantees the exception will be caught, regardless
		/// of the logger implementation
		/// </summary>
		public static void LogIgnoringAnyError(this ILogEvents logger, LogLevel logLevel, Func<string> contentGenerator, Exception exception)
		{
			try
			{
				logger.Log(logLevel, DateTime.Now, contentGenerator, exception);
			}
			catch { }
		}

		/// <summary>
		/// Wrap logging request in a try..catch and swallow any exception - this is an extension method that guarantees the exception will be caught, regardless
		/// of the logger implementation
		/// </summary>
		public static void LogIgnoringAnyError(this ILogEvents logger, LogLevel logLevel, Func<string> contentGenerator)
		{
			LogIgnoringAnyError(logger, logLevel, contentGenerator, null);
		}
	}
}
