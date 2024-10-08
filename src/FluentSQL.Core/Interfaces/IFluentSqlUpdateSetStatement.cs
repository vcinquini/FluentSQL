﻿using System.Collections.Generic;
using System.Threading.Tasks;

namespace FluentSQL.Core;

/// <summary>
/// Represents an UPDATE statement with the SET clause applied.
/// </summary>
public interface IFluentSqlUpdateSetStatement
{
	/// <summary>
	/// Returns the string representing the query in it's current state.
	/// </summary>
	string Query { get; }
	/// <summary>
	/// Maximum allowed time for a query to finish executing.         
	/// </summary>
	int? Timeout { get; }

	/// <summary>
	/// Applies the WHERE operator using the specified condition.
	/// </summary>
	/// <param name="condition">Filter condition.</param>
	IFluentSqlNonQueryWhereStatement Where(string condition);
	/// <summary>
	/// Applies the WHERE operator using the specified condition.
	/// </summary>
	/// <param name="condition">Filter condition.</param>
	/// <param name="parameters">Collection of key-value pairs containing parameter names and values.</param>
	IFluentSqlNonQueryWhereStatement Where(string condition, Dictionary<string, object> parameters);
	/// <summary>
	/// Applies the WHERE operator using the specified condition.
	/// </summary>
	/// <param name="condition">Filter condition.</param>
	/// <param name="parameters">Object containing parameter names and values.</param>
	IFluentSqlNonQueryWhereStatement Where(string condition, object parameters);

	/// <summary>
	/// Executes the operation.
	/// </summary>
	/// <returns>Affected rows.</returns>
	int Execute();
	/// <summary>
	/// Executes the operation asynchronously.
	/// </summary>
	/// <returns>A task with the affected rows.</returns>
	Task<int> ExecuteAsync();
}
