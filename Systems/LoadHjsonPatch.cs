using CalamityCN.Utils;
using System.Reflection;
using System;
using Terraria.ModLoader;
using System.Collections.Generic;
using Hjson;
using Newtonsoft.Json.Linq;
using System.IO;
using System.Text;
using Terraria.Localization;
using Terraria.ModLoader.Config;
using Terraria.ModLoader.Core;

namespace CalamityCN.Systems
{
    public class LoadHjsonPatch : OnPatcher
    {
        public override bool AutoLoad => true;

        public override MethodInfo ModifiedMethod => typeof(LocalizationLoader).GetCachedMethod("AutoloadTranslations");

        public override Delegate Delegate => new Action<Mod, Dictionary<string, ModTranslation>>(AutoloadTranslations);

        public static void AutoloadTranslations(Mod mod, Dictionary<string, ModTranslation> modTranslationDictionary)
        {
            foreach (TmodFile.FileEntry translationFile in GetFile(mod))
            {
                if (Path.GetExtension(translationFile.Name) == ".hjson")
                {
                    string pathName = translationFile.Name;
                    GameCulture culture = FromPathOverride(ref pathName);
                    using Stream stream = GetFile(mod).GetStream(pathName);
                    using StreamReader streamReader = new StreamReader(stream, Encoding.UTF8, true);
                    string hjsonString = streamReader.ReadToEnd();
                    JToken jtoken = JObject.Parse(HjsonValue.Parse(hjsonString).ToString());
                    Dictionary<string, string> flattened = new Dictionary<string, string>();
                    foreach (JToken t in jtoken.SelectTokens("$..*"))
                    {
                        if (!t.HasValues)
                        {
                            string path = "";
                            JToken current = t;
                            for (JToken parent = t.Parent; parent != null; parent = parent.Parent)
                            {
                                JProperty property = parent as JProperty;
                                string text;
                                if (property == null)
                                {
                                    JArray array = parent as JArray;
                                    if (array == null)
                                    {
                                        text = path;
                                    }
                                    else
                                    {
                                        text = array.IndexOf(current).ToString() + ((path == string.Empty) ? string.Empty : ("." + path));
                                    }
                                }
                                else
                                {
                                    text = property.Name + ((path == string.Empty) ? string.Empty : ("." + path));
                                }

                                path = text;
                                current = parent;
                            }

                            flattened.Add(path, t.ToString());
                        }
                    }

                    foreach (KeyValuePair<string, string> keyValuePair in flattened)
                    {
                        string text;
                        string text2;
                        keyValuePair.Deconstruct(out text, out text2);
                        string text3 = text;
                        string value = text2;
                        string effectiveKey = text3.Replace(".$parentVal", "");
                        ModTranslation mt;
                        if (!modTranslationDictionary.TryGetValue(effectiveKey, out mt))
                        {
                            mt = (modTranslationDictionary[effectiveKey] = LocalizationLoader.CreateTranslation(effectiveKey));
                        }

                        mt.AddTranslation(culture, value);
                    }
                }
            }
        }

        private static TmodFile GetFile(Mod mod) => mod.GetType().GetProperty("File", BindingFlags.Instance | BindingFlags.NonPublic)!.GetValue(mod) as TmodFile;

        private static GameCulture FromPathOverride(ref string path)
        {
            if (!path.Contains("Localization/CalamityMod/zh"))
                return GameCulture.FromPath(path);

            path = CalamityCNConfig.Instance.Lang switch
            {
                zhCNLang.zh => "Localization/CalamityMod/zh-Hans-zh.hjson",
                zhCNLang.hk => "Localization/CalamityMod/zh-Hant-hk.hjson",
                zhCNLang.tw => "Localization/CalamityMod/zh-Hant-tw.hjson",
                _ => path
            };
            return GameCulture.FromCultureName(GameCulture.CultureName.Chinese);
        }
    }

    public enum zhCNLang
    {
        [Label("简体中文")]
        zh,
        [Label("繁体中文（香港）")]
        hk,
        [Label("繁体中文（台灣）")]
        tw
    }
}