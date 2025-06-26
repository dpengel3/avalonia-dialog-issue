// ----------------------------------------------------------------------
// <copyright file="DialogView.axaml.cs" company="Serosep Limited">
//   Copyright 2024
//   All rights reserved. All source code is an unpublished work and 
//   the use of a copyright notice does not imply otherwise.  This 
//   source code contains confidential and trade secret material. 
//   Any attempt or participation in deciphering, decoding, reverse 
//   engineering or in any way altering the source code is strictly 
//   prohibited, unless the prior written consent of the company is 
//   obtained.  This is proprietary and confidential to Serosep Limited
// </copyright>
// ------------------------------------------------------------------------

namespace aui_dialog.Views;

using System;

using aui_dialog.ViewModels;

using Avalonia.Controls;
using Avalonia.Interactivity;

#pragma warning disable CA1501

public partial class DialogView : Window
{
    public DialogView()
    {
        InitializeComponent();
    }

    protected override void OnLoaded(RoutedEventArgs e)
    {
        base.OnLoaded(e);

        var vm = DataContext as DialogViewModel;
        IDisposable? closer = null;
        closer = vm?.CloseCommand?.Subscribe(x =>
        {
            this.Close(x);
            closer?.Dispose();
        });
    }
}