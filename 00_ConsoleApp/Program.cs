﻿using _00_ConsoleApp.Services;

var menu = new Menu();
menu.FilePath = @$"{Environment.GetFolderPath(Environment.SpecialFolder.Desktop)}\content.json";


while(true)
{
    Console.Clear();
    menu.WelcomeMenu();
}