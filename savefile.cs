using System.IO;
using UnityEngine;
using System.Runtime.Serialization.Formatters.Binary;

public static class savefile
{
    public static void SavePlayer (metadata info)
    {
        BinaryFormatter formatter = new BinaryFormatter();
        string path = Application.persistentDataPath + "/cleanify_player.fun";
        FileStream stream = new FileStream(path, FileMode.Create);

        //file name in which playerdata is stored.
        playerdata data = new playerdata(info);

        formatter.Serialize(stream, data);
        stream.Close();
    }

    public static playerdata LoadPlayer ()
    {
        string path = Application.persistentDataPath + "/cleanify_player.fun";
        if (File.Exists(path))
        {
            BinaryFormatter formatter = new BinaryFormatter();
            FileStream stream = new FileStream(path, FileMode.Open);

            playerdata data = formatter.Deserialize(stream) as playerdata;
            stream.Close();

            return data;
        }
        else
        {
            Debug.LogError("Save file not found in " + path);
            return null;
        }
    }
}