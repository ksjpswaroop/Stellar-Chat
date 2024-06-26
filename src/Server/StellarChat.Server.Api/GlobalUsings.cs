﻿global using Mapster;
global using MapsterMapper;
global using Mediator;
global using MongoDB.Driver;
global using MongoDB.Driver.Linq;

global using Microsoft.AspNetCore.Mvc;
global using Microsoft.AspNetCore.SignalR;
global using System.ComponentModel.DataAnnotations;
global using Microsoft.Extensions.DependencyInjection.Extensions;
global using System.Reflection;

global using StellarChat.Server.Api;
global using StellarChat.Server.Api.DAL.Mongo.Documents.Chat;
global using StellarChat.Server.Api.DAL.Mongo.Exceptions.Chat;
global using StellarChat.Server.Api.DAL.Mongo.Repositories.Chat;
global using StellarChat.Server.Api.Domain.Chat.Models;
global using StellarChat.Server.Api.Domain.Chat.Repositories;
global using StellarChat.Server.Api.Hubs;
global using StellarChat.Shared.Abstractions.API.Endpoints;
global using StellarChat.Shared.Abstractions.Exceptions;
global using StellarChat.Shared.Abstractions.Pagination;
global using StellarChat.Shared.Contracts.Chat;
global using StellarChat.Shared.Infrastructure;
global using StellarChat.Shared.Infrastructure.DAL.Mongo;
