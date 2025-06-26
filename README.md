# Avalonia UI Dialog/TextBox Issue
This is a minimal project to demonstrate an issue with AvaloniaUI.

Briefly, after a dialog is opened and closed from a main window, text boxes on the main window can no longer receive text. They can receive focus (and show the blinking text cursor), but keystrokes do not result in text entry. When this happens, the workaround is to select or launch a different application, such as a file browser or terminal, and then return to the application in question. Then the text box will work as expected, until the next time a dialog is shown from the application.

This application uses .Net8. To build for ARM Linux, open a CMD terminal and issue the command (in the project directory):

```
dotnet build /p:Platform=ARM64 --configuration=release
```

Then publish with :

```
dotnet publish --no-build /p:Platform=ARM64 --configuration=release
```

The resulting project is in publish/ARM64/aui_dialog. Copy these files to the ARM platform and run aui_dialog.
