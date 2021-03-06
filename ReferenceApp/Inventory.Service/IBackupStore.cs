﻿// ------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All rights reserved.
//  Licensed under the MIT License (MIT). See License.txt in the repo root for license information.
// ------------------------------------------------------------

namespace Inventory.Service
{
    using System.Threading;
    using System.Threading.Tasks;

    public interface IBackupStore
    {
        Task InitializeAsync(CancellationToken cancellationToken);

        Task<bool> CheckIfBackupExistsInShareAsync(CancellationToken cancellationToken);

        Task UploadBackupFolderAsync(string backupFolder, string backupId, CancellationToken cancellationToken);

        Task<string> DownloadAnyBackupAsync(CancellationToken cancellationToken);

        Task DeleteLastDownloadedBackupAsync(CancellationToken cancellationToken);

        Task DeleteStoreAsync(CancellationToken cancellationToken);

        Task DeleteBackupsAzureAsync(CancellationToken cancellationToken);
    }
}