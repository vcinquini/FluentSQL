﻿using System.Collections.Generic;

namespace FluentSQL.Core;

/// <summary>
/// Represents a SELECT statement with a JOIN clause including the WITH (NOLOCK) modifier.
/// </summary>
public interface IFluentSqlSelectJoinWithNoLockStatement
{
	/// <summary>
	/// Applies the ON keyword after a JOIN, using the specified condition.
	/// </summary>
	/// <param name="condition">Join condition.</param>
	IFluentSqlSelectJoinOnStatement On(string condition);
	/// <summary>
	/// Applies the ON keyword after a JOIN, using the specified condition.
	/// </summary>
	/// <param name="condition">Join condition.</param>
	/// <param name="parameters">Collection of key-value pairs containing parameter names and values.</param>
	IFluentSqlSelectJoinOnStatement On(string condition, Dictionary<string, object> parameters);
	/// <summary>
	/// Applies the ON keyword after a JOIN, using the specified condition.
	/// </summary>
	/// <param name="condition">Join condition.</param>
	/// <param name="parameters">Object containing parameter names and values.</param>
	IFluentSqlSelectJoinOnStatement On(string condition, object parameters);
}
