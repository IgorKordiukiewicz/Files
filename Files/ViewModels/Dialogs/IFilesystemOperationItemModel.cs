﻿using Files.Enums;

namespace Files.ViewModels.Dialogs
{
    public interface IFilesystemOperationItemModel
    {
        string SourcePath { get; }

        string DestinationPath { get; }

        bool IsConflicting { get; }

        FileNameConflictResolveOptionType ConflictResolveOption { get; }

        FilesystemOperationType ItemOperation { get; }
    }
}