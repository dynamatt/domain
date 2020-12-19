/* 
 * Domain Public API
 *
 * See https://developer.domain.com.au for more information
 *
 * OpenAPI spec version: v2
 * Contact: api@domain.com.au
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */
using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using SwaggerDateConverter = Domain.Client.SwaggerDateConverter;

namespace Domain.Model
{
    /// <summary>
    /// Defines PreMarket.v1.AuthorityType
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
        public enum PreMarketV1AuthorityType
    {
        /// <summary>
        /// Enum PrivateSale for value: privateSale
        /// </summary>
        [EnumMember(Value = "privateSale")]
        PrivateSale = 1,
        /// <summary>
        /// Enum Auction for value: auction
        /// </summary>
        [EnumMember(Value = "auction")]
        Auction = 2,
        /// <summary>
        /// Enum ExpressionOfInterest for value: expressionOfInterest
        /// </summary>
        [EnumMember(Value = "expressionOfInterest")]
        ExpressionOfInterest = 3    }
}