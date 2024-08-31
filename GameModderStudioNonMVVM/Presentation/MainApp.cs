using GameModderStudioNonMVVM.Helpers;

namespace GameModderStudioNonMVVM.Presentation;

public partial class MainApp : Form
{
    public MainApp()
    {
        InitializeComponent();

        GetCharacterMappingIDs();
    }

    private void GetCharacterMappingIDs()
    {
        JsonParser.ReadToTreeView(@"./CharacterMappingSample.json");
    }
}
