using System.Collections.Generic;

namespace FluentSQL.Core;

/// <summary>
/// Represents a SELECT statement with the TOP clause applied.
/// </summary>
public interface IFluentSqlSelectTopStatement : IFluentSqlQueryEnd
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
	/// Applies the FROM operator indicating the table to query.
	/// </summary>
	/// <param name="table">Name of the table.</param>
	IFluentSqlSelectFromStatement From(string table);
	/// <summary>
	/// Applies the FROM operator indicating the table to query.
	/// </summary>
	/// <param name="table">Name of the table.</param>
	/// <param name="tableAlias">Alias of the table.</param>
	IFluentSqlSelectFromStatement From(string table, string tableAlias);
	/// <summary>
	/// Applies the FROM operator indicating the tables to query.
	/// </summary>
	/// <param name="tables">Array of Tables Names.</param>
	IFluentSqlSelectFromStatement From(params string[] tables);
}
