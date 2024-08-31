using GameModderStudioNonMVVM.Model;
using System.Text.Json;

namespace GameModderStudioNonMVVM.Helpers;

internal class JsonParser
{   
    public static void ReadToTreeView(string fileName)
    {
        // Read entire JSON into a variable
        var jsonString = File.ReadAllText(fileName);

        // Instantize the model
        var characterMapping = new CharacterMapping();

        // Deserialize the data and put it into the model.
        characterMapping = JsonSerializer.Deserialize<CharacterMapping>(jsonString);

        // MISSING LOOP?

        // Output
        Console.WriteLine(characterMapping.ToString());
    }
}
 