using FluentSQL.Core;

namespace UnitTests;

public class CRUDUnitTests
{
	private string CONNECTION_STRING = "DummyConnection";

	[Fact]
	public void Test_Simple_Select()
	{

		var fsql = FluentSqlBuilder.Connect(CONNECTION_STRING);

		fsql.Select("C.Name", "C.Surname")
			.From("Customers", "C");

		Assert.Equal("SELECT C.Name, C.Surname FROM Customers C", fsql.Query);

	}

	[Fact]
	public void Test_Simple_Select_With_Multiple_Tables()
	{

		var fsql = FluentSqlBuilder.Connect(CONNECTION_STRING);

		fsql.Select("Name", "Surname", "Invoice")
			.From(new string[] { "Customers", "Invoices" });

		Assert.Equal("SELECT Name, Surname, Invoice FROM Customers, Invoices", fsql.Query);

	}

	[Fact]
	public void Test_Simple_Select_With_Simple_Where()
	{
		var fsql = FluentSqlBuilder.Connect(CONNECTION_STRING);

		fsql.Select("Name", "Surname")
			.From("Customers")
			.Where("ID > 5");

		Assert.Equal("SELECT Name, Surname FROM Customers WHERE ID > 5", fsql.Query);

	}

	[Fact]
	public void Test_Simple_Select_With_Top_And_Simple_Where()
	{
		var fsql = FluentSqlBuilder.Connect(CONNECTION_STRING);

		fsql.Select("Name", "Surname")
			.Top(100)
			.From("Customers")
			.Where("ID > 5");

		Assert.Equal("SELECT TOP 100 Name, Surname FROM Customers WHERE ID > 5", fsql.Query);

	}
}