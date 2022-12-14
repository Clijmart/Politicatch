using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Party
{
    public string name;
    public List<string> descriptions = new List<string>();

    /// <summary>
    /// Pick a random description for this party.
    /// </summary>
    /// <returns>A random description</returns>
    public string RandomDescription()
    {
        return descriptions[Random.Range(0, descriptions.Count)];
    }
}

[System.Serializable]
public class Parties
{
    public Party[] parties;
}