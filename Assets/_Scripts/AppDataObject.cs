using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New App Data", menuName = "AppData")]
public class AppDataObject : ScriptableObject
{
    [SerializeField]
    private string version;

    public AppInfo appInformation;
    public DevInfo develInformation;
}

[Serializable]
public class AppInfo
{
    [SerializeField]
    private string name;

    [SerializeField]
    private string companyName;

    [SerializeField]
    private string bundleID;

    [SerializeField]
    [TextArea(3, 10)]
    public string description;

    public ReleaseNotes releaseNotes;
}

[Serializable]
public class DevInfo
{
    [SerializeField]
    private Developer maintainer;

    [SerializeField]
    private Developer reviewer;
}

[Serializable]
public class Developer
{
    [SerializeField]
    private string name;

    [SerializeField]
    private string email;

    [SerializeField]
    private string phoneNumber;
}

[Serializable]
public class ReleaseNotes
{
    [SerializeField] private string note1;
    [SerializeField] private string note2;
    [SerializeField] private string note3;
    [SerializeField] private string note4;
    [TextArea]
    [SerializeField] private string additonalInformation;
}