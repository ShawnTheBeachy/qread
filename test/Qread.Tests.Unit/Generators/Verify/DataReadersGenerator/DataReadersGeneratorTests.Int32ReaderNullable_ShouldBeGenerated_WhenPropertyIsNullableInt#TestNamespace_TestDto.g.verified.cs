﻿//HintName: TestNamespace_TestDto.g.cs
// <auto-generated />
#nullable enable

using System.Data;

namespace TestNamespace;

partial record TestDto
{
    public static TestDto FromDataReader(IDataReader reader)
    {
        var instance = new TestDto
        {
            Count = reader.IsDBNull(0) ? null : reader.GetInt32(0),
            Count2 = reader.IsDBNull(1) ? null : reader.GetInt32(1)
        };
        return instance;
    }

    public static IReadOnlyList<TestDto> ListFromDataReader(IDataReader reader)
    {
        var results = new List<TestDto>();

        while (reader.Read())
        {
            var instance = FromDataReader(reader);
            results.Add(instance);
        }

        return results;
    }
}
