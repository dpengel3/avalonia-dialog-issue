// ----------------------------------------------------------------------
// <copyright file="DialogViewModel.cs" company="Serosep Limited">
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

namespace aui_dialog.ViewModels;

using System.Reactive;
using ReactiveUI;

public class DialogViewModel : ViewModelBase
{
    public DialogViewModel()
    {
        CloseCommand = ReactiveCommand.Create(() => 
        {
            return true; 
        });
    }

    public string Text { get; set; } = string.Empty;

    public ReactiveCommand<Unit, bool> CloseCommand { get; }    
}
