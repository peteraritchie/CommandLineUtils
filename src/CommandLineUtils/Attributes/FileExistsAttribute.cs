﻿// Copyright (c) Nate McMaster.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System;

namespace McMaster.Extensions.CommandLineUtils
{
    /// <summary>
    /// Specifies that the data must be an already existing file, not a directory.
    /// </summary>
    [AttributeUsage(AttributeTargets.Property)]
    public sealed class FileExistsAttribute : FilePathExistsAttribute
    {
        /// <summary>
        /// Initializes an instance of <see cref="FileExistsAttribute"/>.
        /// </summary>
        public FileExistsAttribute()
            : base(Abstractions.FilePathType.File)
        {
        }
    }
}
