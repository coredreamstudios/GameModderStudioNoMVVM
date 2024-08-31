namespace GameModderStudioNonMVVM.Model;

public class CharacterMapping
{
    public ushort CharacterId { get; set; } = 0;
    public ushort AttireNumber { get; set; } = 0;
    public ulong CharacterFolderPath { get; set; } = 0;
    public ulong CharacterAttireFolderPath { get; set; } = 0;
    public ulong CharacterBaseModelMDLFile { get; set; } = 0;
    public ulong CharacterBaseModelMTLFile { get; set; } = 0;
    public ulong CharacterAttireMDLFile { get; set; } = 0;
    public ulong CharacterAttireMTLFile { get; set; } = 0;


}
