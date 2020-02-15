using System.Runtime.Serialization.Formatters.Binary;
using UnityEngine;
using System.IO;
using System;

public class SAV_Version_One
{
    // Something - replace with another
    // object whereDoWeGet - replace with another

    public static void SaveData(object whereDoWeGet)
    {
        BinaryFormatter binaryFormatter = new BinaryFormatter();
        if (!File.Exists(Application.dataPath + "/data")) Directory.CreateDirectory(Application.dataPath + "/data");
        FileStream fileStream = new FileStream(Application.dataPath + "/data/Something.sav", FileMode.Create);
        Data data = new Data(whereDoWeGet);
        binaryFormatter.Serialize(fileStream, data);
        fileStream.Close();
    }

    public static int[] LoadData()
    {
        if (File.Exists(Application.dataPath + "/data/Something.sav"))
        {
            BinaryFormatter binaryFormatter = new BinaryFormatter();
            FileStream fileStream = new FileStream(Application.dataPath + "/data/Something.sav", FileMode.Open);
            Data data = binaryFormatter.Deserialize(fileStream) as Data;
            fileStream.Close();
            return data.Other;
        }
        else return new int[0];
    }
}

[Serializable]
public class Data
{
    public int[] Other;

    public Data(object whereDoWeGet)
    {
        Other = new int[1];
     // Other[0] = whereDoWeGet.Value;
    }
}