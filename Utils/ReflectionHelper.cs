using System;
using System.Collections.Generic;
using System.Reflection;

namespace CalamityCN.Utils
{ 
	internal static class ReflectionHelper
	{
		private static Dictionary<ReflectionHelper.ReflectionType, Dictionary<string, object>> ReflectionCache
		{
			get
			{
				Dictionary<ReflectionHelper.ReflectionType, Dictionary<string, object>> dictionary = new Dictionary<ReflectionHelper.ReflectionType, Dictionary<string, object>>();
				dictionary.Add(ReflectionType.Field, new Dictionary<string, object>());
				dictionary.Add(ReflectionType.Property, new Dictionary<string, object>());
				dictionary.Add(ReflectionType.Type, new Dictionary<string, object>());
				dictionary.Add(ReflectionType.Constructor, new Dictionary<string, object>());
				dictionary.Add(ReflectionType.Method, new Dictionary<string, object>());
				return dictionary;
			}
		}

		private static BindingFlags UniversalFlags
		{
			get
			{
				return BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic;
			}
		}

		internal static MethodInfo GetCachedMethod(this Type type, string methodName)
		{
			return ReflectionHelper.RetrieveFromCache<MethodInfo>(ReflectionHelper.ReflectionType.Method, ReflectionHelper.GetMethodNameForCache(type, methodName), () => type.GetMethod(methodName, ReflectionHelper.UniversalFlags));
		}

		private static string GetMethodNameForCache(Type type, string method)
		{
			string assemblyName = type.Assembly.GetName().Name;
			string typeName = type.Name;

			return assemblyName + "." + typeName + "::" + method;
		}

		private static TReturn RetrieveFromCache<TReturn>(ReflectionHelper.ReflectionType refType, string key, Func<TReturn> fallback)
		{
			if (ReflectionHelper.ReflectionCache[refType].ContainsKey(key))
			{
				return (TReturn)((object)ReflectionHelper.ReflectionCache[refType][key]);
			}
			TReturn value = fallback();
			ReflectionHelper.ReflectionCache[refType].Add(key, value);
			return value;
		}

		private enum ReflectionType
		{
			Field,
			Property,
			Method,
			Constructor,
			Type
		}
	}
}
