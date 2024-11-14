﻿using System.Diagnostics.CodeAnalysis;
using System.Text.Json.Serialization;

namespace CompraFacil.Application.Common.Models;

[ExcludeFromCodeCoverage]
public sealed class BaseResponse<TData>
{
    [JsonPropertyName("data")]
    public TData? Data { get; private set; }
}