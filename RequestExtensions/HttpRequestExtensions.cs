﻿using Microsoft.AspNetCore.Http;
using System;
using System.IO;
using System.Text.Json;
using System.Threading.Tasks;

namespace AO.Extensions
{
    public static class RequestExtensions
    {
        public static async Task<(string Json, T Item)> DeserializeWithJsonAsync<T>(this HttpRequest request)
        {
            try
            {               
                using (var reader = new StreamReader(request.Body))
                {
                    string requestBody = await reader.ReadToEndAsync();
                    T item = JsonSerializer.Deserialize<T>(requestBody);
                    return (requestBody, item);
                }
            }
            catch (Exception exc)
            {
                throw new Exception($"Error deserializing request to type {typeof(T).Name}: {exc.Message}", exc);
            }
        }

        public static async Task<T> DeserializeAsync<T>(this HttpRequest request)
        {
            var result = await DeserializeWithJsonAsync<T>(request);
            return result.Item;
        }
    }
}