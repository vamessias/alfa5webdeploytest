﻿using Microsoft.Maui.Controls.Handlers.Items;
using Alfa5.Maui.Settings;

namespace Alfa5.Maui;

public partial class App : Application
{
    private readonly ThemeManager themeManager;

    public App(IServiceProvider serviceProvider)
    {
        InitializeComponent();
        
        themeManager = serviceProvider.GetRequiredService<ThemeManager>();

        MainPage = serviceProvider.GetRequiredService<AppShell>();

        CollectionViewHandler.Mapper.AppendToMapping("HeaderAndFooterFix", (_, collectionView) =>
        {
            collectionView.AddLogicalChild(collectionView.Header as Element);
            collectionView.AddLogicalChild(collectionView.Footer as Element);
        });
    }

    protected override async void OnStart()
    {
        base.OnStart();

        App.Current!.UserAppTheme = await themeManager.GetAppThemeAsync();
    }
}
