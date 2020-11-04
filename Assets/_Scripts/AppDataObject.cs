using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New AppDataObject", menuName = "AppData")]
public class AppDataObject : ScriptableObject
{
    [SerializeField]
    private string version;

    public AppInfo appInformation;
}

[Serializable]
public class AppInfo
{
    [SerializeField]
    private string name;

    [SerializeField]
    private string companyName;

    public string maintainer;
    public string email;

    public BuildInfo buildInfo;

    [Serializable]
    public class BuildInfo
    {
        [SerializeField]
        private string bundleID;

        [TextArea(3, 10)]
        public string description;
    }
}
