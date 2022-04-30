using TextBasedRPG;

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
    }
}

while (Screens.roomString != "end-loop")
{
    do
    {
        RoomLoader(Screens.roomString);
    }
    while (Screens.roomString != "");
}



Console.ReadKey();