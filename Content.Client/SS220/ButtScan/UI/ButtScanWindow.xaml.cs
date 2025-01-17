﻿// © SS220, An EULA/CLA with a hosting restriction, full text: https://raw.githubusercontent.com/SerbiaStrong-220/space-station-14/master/CLA.txt

using Content.Client.UserInterface.Controls;
using Content.Shared.SS220.ButtScan;
using Robust.Client.AutoGenerated;
using Robust.Client.UserInterface.CustomControls;
using Robust.Client.UserInterface.XAML;

namespace Content.Client.SS220.ButtScan.UI;

[GenerateTypedNameReferences]
public sealed partial class ButtScanWindow : BaseWindow
{
    public ButtScanWindow()
    {
        RobustXamlLoader.Load(this);

        CloseButton.OnPressed += _ => Close();
    }

    public void InitVisuals(ButtScanComponent scan)
    {
        ContentsImage.TexturePath = scan.ButtTexturePath;
        ContentsImage.MinSize = ContentsImage.TextureNormal?.Size ?? Vector2.Zero;
    }

    // Drag by grabbing anywhere
    protected override DragMode GetDragModeFor(Vector2 relativeMousePos)
    {
        return DragMode.Move;
    }
}
