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
        case "room-2-A":
            {
                Screens.RoomTwoA();
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
    //if (operatingsystem.iswindows())
    //{
    //    soundplayer gamemusic = new soundplayer("c:\\users\\admin.quinten\\documents\\c# projects\\textbasedrpg\\unamedtextbasedgame\\textbasedrpg\\gamemusic.wav");
    //    gamemusic.load();
    //    gamemusic.playlooping();
    //}
    do
    {
        RoomLoader(Screens.roomString);
    }
    while (Screens.roomString != "");
}

Console.ReadKey();