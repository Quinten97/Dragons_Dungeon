using TextBasedRPG;
using System.Media;

static void RoomLoader(string switchKey)
{


    switch (switchKey)
    {
        case "title-screen":
            {
                Screens.TitleScreen();
                break;
            }
        case "class-screen":
            {
                Screens.ClassScreen();
                break;
            }
        case "player-name-screen":
            {
                Screens.PlayerNameScreen();
                break;
            }
        case "cutscene-one":
            {
                Screens.CutSceneOne();
                break;
            }
        case "room-1-A":
            {
                Screens.RoomOneA();
                break;
            }
        case "inventory":
            {
                Inventory.DrawInventory();
                break;
            }
        case "combat":
            {
                Combat.CombatRoom();
                break;
            }
    }
}

while (Screens.roomString != "end-loop")
{
    if (OperatingSystem.IsWindows())
    {
        SoundPlayer gameMusic = new SoundPlayer("C:\\Users\\admin.quinten\\Documents\\C# Projects\\TextBasedRPG\\unamedTextBasedGame\\TextBasedRPG\\GameMusic.wav");
        gameMusic.Load();
        gameMusic.PlayLooping();
    }
    do
    {
        RoomLoader(Screens.roomString);
    }
    while (Screens.roomString != "");
}

Console.ReadKey();