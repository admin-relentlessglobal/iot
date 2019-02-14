﻿// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

namespace Iot.Device.Ssd1306.Command
{
    public class SetNormalDisplay : ICommand
    {
        /// <summary>
        /// This command sets the display to be normal.  Displays a RAM data of 1 indicates an ON pixel.
        /// </summary>
        public SetNormalDisplay()
        {
        }

        /// <summary>
        /// The value that represents the command.
        /// </summary>
        public byte Id => 0xA6;

        /// <summary>
        /// Gets the bytes that represent the command.
        /// </summary>
        /// <returns>The bytes that represent the command.</returns>
        public byte[] GetBytes()
        {
            return new byte[] { Id };
        }
    }
}
