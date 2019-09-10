using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection;
using System.Text;

namespace Infra.Extensions
{
    public static class EnumExtensions
    {
        /// <summary>
        /// Return a List of enums in a Enum class
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public static List<T> GetEnumList<T>()
        {
            return Enum.GetValues(typeof(T))
                ?.Cast<T>()
                ?.ToList() ?? new List<T>();
        }

        /// <summary>
        /// Return display name of enum property
        /// </summary>
        /// <param name="enum"></param>
        /// <returns></returns>
        public static string GetName(this Enum @enum)
        {
            return @enum.GetType()
                ?.GetMember(@enum.ToString())
                ?.FirstOrDefault()
                ?.GetCustomAttribute<DisplayAttribute>()
                ?.Name ?? @enum.ToString();
        }

        /// <summary>
        /// Return description of enum property
        /// </summary>
        /// <param name="enum"></param>
        /// <returns></returns>
        public static string GetDescription(this Enum @enum)
        {
            return @enum.GetType()
                ?.GetMember(@enum.ToString())
                ?.FirstOrDefault()
                ?.GetCustomAttribute<DescriptionAttribute>()
                ?.Description ?? @enum.ToString();
        }
    }
}
