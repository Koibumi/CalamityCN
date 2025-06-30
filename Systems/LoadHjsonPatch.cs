/* CalamityCN.Utils;
using System.Reflection;
using System;
using Terraria.ModLoader;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Terraria.Localization;
using Terraria.ModLoader.Core;
using Hjson;
using Newtonsoft.Json.Linq;
using System.Text;
using Terraria;

namespace CalamityCN.Systems
{
    
    public class LoadHjsonPatch : OnPatcher
    {
        
        public override bool AutoLoad => false;

        public override MethodInfo ModifiedMethod => typeof(LocalizationLoader).GetCachedMethod("LoadTranslations");

        public override Delegate Delegate => new Func<LoadTranslationsPatch, Mod, GameCulture, List<(string key, string value)>>(LoadTranslationsOverride);

        private static List<(string key, string value)> LoadTranslationsOverride(LoadTranslationsPatch orig, Mod mod, GameCulture culture)
        {
            if (GetFile(mod) == null)
                return new List<(string key, string value)>();
            try
            {
                if (culture != GameCulture.FromCultureName(GameCulture.CultureName.Chinese) || mod.Name != nameof(CalamityCN))
                    return orig.Invoke(mod, culture);

                List<(string, string)> valueTupleList = new List<(string, string)>();
                foreach (TmodFile.FileEntry entry in GetFile(mod)
                             .Where<TmodFile.FileEntry>((Func<TmodFile.FileEntry, bool>)(entry =>
                                 Path.GetExtension(entry.Name) == ".hjson")))
                {
	                (GameCulture culture1, string prefix) = LocalizationLoader.TryGetCultureAndPrefixFromPath(entry.Name, out culture, out prefix) ? (culture, prefix) : (GameCulture.DefaultCulture, string.Empty);
                    if (culture1 == GameCulture.FromCultureName(GameCulture.CultureName.Chinese) &&
                        culture1 == culture && (!entry.Name.Contains("CalamityMod") || entry.Name.Contains(GetLangIdentifier())))
                    {
                        #region FromDecompile
                        using (Stream stream = GetFile(mod).GetStream(entry))
                        {
                            using (StreamReader streamReader = new StreamReader(stream, Encoding.UTF8, true))
                            {
                                string hjsonString = streamReader.ReadToEnd();
                                string path2 = Path.Combine(mod.Name, entry.Name).Replace('/', '\\');
                                if ((typeof(LocalizationLoader)
                                        .GetField("changedFiles", BindingFlags.Static | BindingFlags.NonPublic)
                                        .GetValue(null) as HashSet<(string Mod, string fileName)>)
                                    .Select(x => Path.Join(x.Mod, x.fileName)).Contains(path2))
                                {
                                    string path =
                                        Path.Combine(
                                            typeof(Main).Assembly.GetTypes().First(t => t.Name == "ModCompile")
                                                .GetField("ModSourcePath", BindingFlags.Static | BindingFlags.Public)
                                                .GetValue(null) as string, path2);
                                    if (File.Exists(path))
                                    {
                                        try
                                        {
                                            hjsonString = File.ReadAllText(path);
                                        }
                                        catch (Exception ex)
                                        {
                                        }
                                    }
                                }

                                string json;
                                try
                                {
                                    json = HjsonValue.Parse(hjsonString).ToString();
                                }
                                catch (Exception ex)
                                {
                                    throw new Exception(
                                        "The localization file \"" + entry.Name +
                                        "\" is malformed and failed to load: ", ex);
                                }

                                foreach (JToken selectToken in JObject.Parse(json).SelectTokens("$..*"))
                                {
                                    if (!selectToken.HasValues &&
                                        (!(selectToken is JObject jobject) || jobject.Count != 0))
                                    {
                                        string str1 = "";
                                        JToken jtoken = selectToken;
                                        JToken parent = (JToken)selectToken.Parent;
                                        while (true)
                                        {
                                            string str2;
                                            switch (parent)
                                            {
                                                case null:
                                                    goto label_23;
                                                case JProperty jproperty:
                                                    str2 = jproperty.Name +
                                                           (str1 == string.Empty ? string.Empty : "." + str1);
                                                    break;
                                                case JArray jarray:
                                                    str2 = jarray.IndexOf(jtoken).ToString() +
                                                           (str1 == string.Empty ? string.Empty : "." + str1);
                                                    break;
                                                default:
                                                    str2 = str1;
                                                    break;
                                            }

                                            str1 = str2;
                                            jtoken = parent;
                                            parent = (JToken)parent.Parent;
                                        }

                                        label_23:
                                        string str3 = str1.Replace(".$parentVal", "");
                                        if (!string.IsNullOrWhiteSpace(prefix))
                                            str3 = prefix + "." + str3;
                                        valueTupleList.Add((str3, selectToken.ToString()));
                                    }
                                }
                            }
                        }
                        #endregion
                    }
                }

                return valueTupleList;
            }
            catch (Exception ex)
            {
                ex.Data[(object)nameof(mod)] = (object)mod.Name;
                throw;
            }
        }

        private static string GetLangIdentifier()
        {
            return CalamityCNConfig.Instance.Lang switch
            {
                zhLang.zh => "zhHans",
                zhLang.hk => "zhHanthk",
                zhLang.tw => "zhHanttw",
                _ => "zhHans"
            };
        }
        private static TmodFile GetFile(Mod mod) => mod.GetType().GetProperty("File", BindingFlags.Instance | BindingFlags.NonPublic)!.GetValue(mod) as TmodFile;

        private delegate List<(string key, string value)> LoadTranslationsPatch(Mod mod, GameCulture culture);
    }

    public enum zhLang
    {
        zh,
        hk,
        tw
    }
    
}*/