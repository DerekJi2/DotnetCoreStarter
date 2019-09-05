using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Dcs.Core.Json
{
    public static class JsonExtensions
    {
        private static readonly DcsCamelCasePropertyNamesContractResolver SharedDcsCamelCasePropertyNamesContractResolver;
        private static readonly DcsContractResolver SharedDcsContractResolver;

        static JsonExtensions()
        {
            SharedDcsCamelCasePropertyNamesContractResolver = new DcsCamelCasePropertyNamesContractResolver();
            SharedDcsContractResolver = new DcsContractResolver();
        }

        /// <summary>
        /// Converts given object to JSON string.
        /// </summary>
        /// <returns></returns>
        public static string ToJsonString(this object obj, bool camelCase = false, bool indented = false, ReferenceLoopHandling refLoopHandling = ReferenceLoopHandling.Ignore)
        {
            var settings = new JsonSerializerSettings();

            if (camelCase)
            {
                settings.ContractResolver = SharedDcsCamelCasePropertyNamesContractResolver;
            }
            else
            {
                settings.ContractResolver = SharedDcsContractResolver;
            }

            if (indented)
            {
                settings.Formatting = Formatting.Indented;
            }

            settings.ReferenceLoopHandling = refLoopHandling;

            return ToJsonString(obj, settings);
        }

        /// <summary>
        /// Converts given object to JSON string using custom <see cref="JsonSerializerSettings"/>.
        /// </summary>
        /// <returns></returns>
        public static string ToJsonString(this object obj, JsonSerializerSettings settings)
        {
            return obj != null
                ? JsonConvert.SerializeObject(obj, settings)
                : default(string);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="obj"></param>
        /// <param name="settings"></param>
        /// <returns></returns>
        public static string ToJsonStringIgnoreSelfLoop(this object obj)
        {
            var settings = new JsonSerializerSettings();
            settings.ReferenceLoopHandling = ReferenceLoopHandling.Ignore;

            return ToJsonString(obj, settings);
        }

        /// <summary>
        /// Returns deserialized string using default <see cref="JsonSerializerSettings"/>
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="value"></param>
        /// <returns></returns>
        public static T FromJsonString<T>(this string value)
        {
            return value.FromJsonString<T>(new JsonSerializerSettings());
        }

        /// <summary>
        /// Returns deserialized string using custom <see cref="JsonSerializerSettings"/>
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="value"></param>
        /// <param name="settings"></param>
        /// <returns></returns>
        public static T FromJsonString<T>(this string value, JsonSerializerSettings settings)
        {
            return value != null
                ? JsonConvert.DeserializeObject<T>(value, settings)
                : default(T);
        }

        /// <summary>
        /// Returns deserialized string using explicit <see cref="Type"/> and custom <see cref="JsonSerializerSettings"/>
        /// </summary>
        /// <param name="value"></param>
        /// <param name="type"></param>
        /// <param name="settings"></param>
        /// <returns></returns>
        public static object FromJsonString(this string value, Type type, JsonSerializerSettings settings)
        {
            if (type == null)
            {
                throw new ArgumentNullException(nameof(type));
            }

            return value != null
                ? JsonConvert.DeserializeObject(value, type, settings)
                : null;
        }
    }
}
