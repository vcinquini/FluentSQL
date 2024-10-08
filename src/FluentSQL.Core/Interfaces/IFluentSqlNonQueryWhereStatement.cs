﻿using System.Threading.Tasks;

namespace FluentSQL.Core;

/// <summary>
/// Represents a filtered non-query statement.
/// </summary>
public interface IFluentSqlNonQueryWhereStatement
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
