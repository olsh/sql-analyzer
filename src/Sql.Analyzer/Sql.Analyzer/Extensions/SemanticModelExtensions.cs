﻿using Microsoft.CodeAnalysis;

namespace Sql.Analyzer.Extensions
{
    internal static class SemanticModelExtensions
    {
        public static INamedTypeSymbol GetDapperSqlMapperSymbol(this SemanticModel semanticModel)
        {
            return semanticModel.Compilation.GetTypeByMetadataName("Dapper.SqlMapper");
        }

        public static INamedTypeSymbol GetLinqEnumerableSymbol(this SemanticModel semanticModel)
        {
            return semanticModel.Compilation.GetTypeByMetadataName("System.Linq.Enumerable");
        }
    }
}
