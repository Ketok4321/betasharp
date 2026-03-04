namespace BetaSharp.Worlds.Maps;

public record struct MapColor // TODO: Move Color from Client project to Core and use it here instead of uint
{
    private static readonly List<MapColor> s_colors = [];

    public static MapColor ById(int id) => s_colors[id];

    public static MapColor Create(uint colorValue)
    {
        int id = s_colors.Count;
        var result = new MapColor(id, colorValue);
        s_colors.Add(result);
        return result;
    }

    public static readonly MapColor Air =      Create(0x000000);
    public static readonly MapColor Grass =    Create(0x7FB238);
    public static readonly MapColor Sand =     Create(0xF7E9A3);
    public static readonly MapColor Cloth =    Create(0xA7A7A7);
    public static readonly MapColor TNT =      Create(0xFF0000);
    public static readonly MapColor Ice =      Create(0xA0A0FF);
    public static readonly MapColor Iron =     Create(0xA7A7A7);
    public static readonly MapColor Foliage =  Create(0x007C00);
    public static readonly MapColor Snow =     Create(0xFFFFFF);
    public static readonly MapColor Clay =     Create(0xA4A8B8);
    public static readonly MapColor Dirt =     Create(0xB76A2F);
    public static readonly MapColor Stone =    Create(0x707070);
    public static readonly MapColor Water =    Create(0x4040FF);
    public static readonly MapColor Wood =     Create(0x685332);

    public int Id { get; }
    public uint ColorValue { get; }

    private MapColor(int id, uint colorValue)
    {
        Id = id;
        ColorValue = colorValue;
    }
}
