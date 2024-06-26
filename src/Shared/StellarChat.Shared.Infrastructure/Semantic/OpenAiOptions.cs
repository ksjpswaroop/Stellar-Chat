﻿namespace StellarChat.Shared.Infrastructure.Semantic;

internal class OpenAiOptions
{
    public const string Key = "openAI";
    public string TextModel { get; set; } = string.Empty;
    public string ApiKey { get; set; } = string.Empty;
    public string OrganizationId { get; set; } = string.Empty;
    public string EmbeddingModel { get; set; } = string.Empty;
}
