using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;

namespace Gw2.Mapper
{
    /// <summary>
    /// Mapper for Guild Wars 2 Api
    /// </summary>
    public class ApiMapper : IApiMapper
    {
        private readonly ILogger<ApiMapper> logger;

        public ApiMapper(ILogger<ApiMapper> logger)
        {
            this.logger = logger;
        }

        /// <summary>
        /// Maps a string to a certain Object type
        /// </summary>
        /// <param name="objectToMap"></param>
        /// <returns></returns>
        public T MapTo<T>(string objectToMap)
        {
            try
            {
                var options = new JsonSerializerOptions
                {
                    ReadCommentHandling = JsonCommentHandling.Skip,
                    AllowTrailingCommas = true,
                    PropertyNameCaseInsensitive = true,
                };
                T result = JsonSerializer.Deserialize<T>(objectToMap, options);
                return result;
            }
            catch (Exception e)
            {
                logger.LogError("Mapping failed: ", objectToMap);
                return default(T);
            }
        }
    }
}
