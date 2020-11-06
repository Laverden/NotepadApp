using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LocalizationSystem
{
    public enum Language
    {
        English,
        Spanish,
        German
    }

    public static Language lang = Language.Spanish;

    private static Dictionary<string, string> localizedEN;
    private static Dictionary<string, string> localizedES;
    private static Dictionary<string, string> localizedGE;

    public static bool isInit;

    public static CSVLoader csvLoader;

    /// <summary>
    /// 
    /// </summary>
    public static void Init()
    {
        csvLoader = new CSVLoader();
        csvLoader.LoadCSV();

        UpdateDictionaries();

        isInit = true;
    }

    public static void UpdateDictionaries()
    {
        localizedEN = csvLoader.GetDictionaryValues("en");
        localizedES = csvLoader.GetDictionaryValues("es");
        localizedGE = csvLoader.GetDictionaryValues("de");
    }

    public static Dictionary<string, string> GetDictionaryForEditor()
    {
        if (!isInit) { Init();  }
        return localizedEN;
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="key"></param>
    /// <returns></returns>
    public static string GetLocalizedValue(string key)
    {
        if (!isInit) { Init(); }

        string value = key;

        switch (lang)
        {
            case Language.English:
                localizedEN.TryGetValue(key, out value);
                break;
            case Language.Spanish:
                localizedES.TryGetValue(key, out value);
                break;
            case Language.German:
                localizedGE.TryGetValue(key, out value);
                break;
        }

        return value;
    }

    public static void Add(string key, string value)
    {
        if (value.Contains("\""))
        {
            value.Replace('"', '\"');
        }

        if (csvLoader == null)
        {
            csvLoader = new CSVLoader();
        }

        csvLoader.LoadCSV();
        csvLoader.Add(key, value);
        csvLoader.LoadCSV();

        UpdateDictionaries();
    }

    public static void Replace(string key, string value)
    {
        if (value.Contains("\""))
        {
            value.Replace('"', '\"');
        }

        if (csvLoader == null)
        {
            csvLoader = new CSVLoader();
        }

        csvLoader.LoadCSV();
        csvLoader.Edit(key, value);
        csvLoader.LoadCSV();

        UpdateDictionaries();
    }

    public static void Remove(string key)
    {
        if (csvLoader == null)
        {
            csvLoader = new CSVLoader();
        }

        csvLoader.LoadCSV();
        csvLoader.Remove(key);
        csvLoader.LoadCSV();

        UpdateDictionaries();
    }


}
