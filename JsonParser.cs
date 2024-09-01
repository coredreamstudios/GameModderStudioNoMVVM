using GameModderStudioNonMVVM.Model;
using System.Text.Json;

namespace GameModderStudioNonMVVM.Helpers;

internal class JsonParser
{   
    public static void ReadToTreeView(string fileName)
    {
        // Read entire JSON into a variable
        var jsonString = File.ReadAllText(fileName);

        // Deserialize the data and put it into the model.
        var characterMapping = JsonSerializer.Deserialize<RootObject>(jsonString);

        foreach (var item in characterMapping.Table)
        {
            TreeNode node = new TreeNode(item.Id.ToString());
            foreach (var prop in typeof(RootObject).GetProperties())
            {
                if (!prop.Name.StartsWith("unk") && !prop.Name.StartsWith("attire_"))
                    node.Nodes.Add(new TreeNode($"{prop.Name}: {prop.GetValue(item)}"));
            }

        }
    }
}

 