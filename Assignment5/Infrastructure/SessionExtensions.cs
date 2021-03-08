using System;
using System.Text.Json;
using Microsoft.AspNetCore.Http;

namespace Assignment5.Infrastructure
{
    public static class SessionExtensions
    {//This is a tool to convert our cart to a JSON string file and back
        public static void SetJson (this ISession session, string key, object value)
        {
            session.SetString(key, JsonSerializer.Serialize(value));
        }

        public static T GetJson<T> (this ISession session, string key)
        {
            var sessionData = session.GetString(key);

            return sessionData == null ? default(T) : JsonSerializer.Deserialize<T>(sessionData);
        }
    }
}
